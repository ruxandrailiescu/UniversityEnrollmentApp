using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnrollmentApp.Entities;

namespace UniversityEnrollmentApp.Forms
{
    public partial class CandidateForm : Form
    {
        #region Form Loading

        private ErrorProvider errorProvider;

        public CandidateForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

            // Setup DataGridView for editing
            dataGridViewCand.AllowUserToAddRows = false;
            dataGridViewCand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCand.MultiSelect = false;
            dataGridViewCand.ReadOnly = false; // Allow editing
            dataGridViewCand.CellEndEdit += DataGridViewCand_CellEndEdit; // Handle cell edit end
            RefreshDataGrid();

            // Attach Validating events
            tbCandFirstName.Validating += new CancelEventHandler(tbCandFirstName_Validating);
            tbCandLastName.Validating += new CancelEventHandler(tbCandLastName_Validating);
            tbCandAddress.Validating += new CancelEventHandler(tbCandAddress_Validating);
            tbFacIdFK.Validating += new CancelEventHandler(tbFacIdFK_Validating);

            // Attach KeyDown event
            this.KeyPreview = true; // Allows the form to receive key events before the focused control
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        #endregion

        #region Candidate Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                int facultyID;
                if (int.TryParse(tbFacIdFK.Text, out facultyID))
                {
                    Faculty faculty = DataSource.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                    if (faculty != null)
                    {
                        Candidate candidate = new Candidate
                        {
                            CandidateID = (int)nudCandID.Value,
                            CandidateFirstName = tbCandFirstName.Text,
                            CandidateLastName = tbCandLastName.Text,
                            CandidateBirthDate = dtpCandBirthDate.Value,
                            CandidateAddress = tbCandAddress.Text,
                            FacultyID = int.Parse(tbFacIdFK.Text),
                            ApplicationStatus = checkBoxAccepted.Checked ? true : false,
                        };
                        DataSource.Candidates.Add(candidate);
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Faculty not found. Please enter a valid Faculty ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid candidate to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearInputControls();
            }
        }

        private void btnUpdateCand_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                // Update the selected candidate
                if (dataGridViewCand.SelectedRows.Count > 0)
                {
                    int index = dataGridViewCand.SelectedRows[0].Index;
                    if (index >= 0 && index < DataSource.Candidates.Count)
                    {
                        DataSource.Candidates[index].CandidateID = (int)dataGridViewCand.Rows[index].Cells[0].Value;
                        DataSource.Candidates[index].CandidateFirstName = dataGridViewCand.Rows[index].Cells[1].Value.ToString();
                        DataSource.Candidates[index].CandidateLastName = dataGridViewCand.Rows[index].Cells[2].Value.ToString();
                        DataSource.Candidates[index].CandidateBirthDate = (DateTime)dataGridViewCand.Rows[index].Cells[3].Value;
                        DataSource.Candidates[index].CandidateAddress = dataGridViewCand.Rows[index].Cells[4].Value.ToString();
                        DataSource.Candidates[index].ApplicationStatus = (bool)dataGridViewCand.Rows[index].Cells[5].Value;
                        DataSource.Candidates[index].FacultyID = (int)dataGridViewCand.Rows[index].Cells[6].Value;
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid candidate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearInputControls();
                }
                else
                {
                    MessageBox.Show("Please select a candidate to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteCand_Click(object sender, EventArgs e)
        {
            // Delete the selected candidate
            if (dataGridViewCand.SelectedRows.Count > 0)
            {
                int index = dataGridViewCand.SelectedRows[0].Index;
                DataSource.Candidates.RemoveAt(index);
                RefreshDataGrid();
                ClearInputControls();
            }
        }

        private void btnClearCand_Click(object sender, EventArgs e)
        {
            // Clear the input controls
            ClearInputControls();
        }

        private void DataGridViewCand_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Update the Candidates list when a cell edit is ended
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < DataSource.Candidates.Count)
            {
                DataSource.Candidates[rowIndex].CandidateID = (int)dataGridViewCand.Rows[rowIndex].Cells[0].Value;
                DataSource.Candidates[rowIndex].CandidateFirstName = dataGridViewCand.Rows[rowIndex].Cells[1].Value.ToString();
                DataSource.Candidates[rowIndex].CandidateLastName = dataGridViewCand.Rows[rowIndex].Cells[2].Value.ToString();
                DataSource.Candidates[rowIndex].CandidateBirthDate = (DateTime)dataGridViewCand.Rows[rowIndex].Cells[3].Value;
                DataSource.Candidates[rowIndex].CandidateAddress = dataGridViewCand.Rows[rowIndex].Cells[4].Value.ToString();
                DataSource.Candidates[rowIndex].ApplicationStatus = (bool)dataGridViewCand.Rows[rowIndex].Cells[5].Value;
                DataSource.Candidates[rowIndex].FacultyID = (int)dataGridViewCand.Rows[rowIndex].Cells[6].Value;
            }
        }

        private void RefreshDataGrid()
        {
            dataGridViewCand.DataSource = null;
            dataGridViewCand.DataSource = DataSource.Candidates;
        }
        private void ClearInputControls()
        {
            nudCandID.Value = 0;
            tbCandFirstName.Clear();
            tbCandLastName.Clear();
            dtpCandBirthDate.Value = DateTime.Now;
            tbCandAddress.Clear();
            tbFacIdFK.Clear();
            checkBoxAccepted.Checked = false;
            errorProvider.Clear();
        }

        #endregion

        #region Validation Events

        private void tbCandFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCandFirstName.Text))
            {
                errorProvider.SetError(tbCandFirstName, "First name cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tbCandFirstName, "");
            }
        }

        private void tbCandLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCandLastName.Text))
            {
                errorProvider.SetError(tbCandLastName, "Last name cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tbCandLastName, "");
            }
        }

        private void tbCandAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCandAddress.Text))
            {
                errorProvider.SetError(tbCandAddress, "Address cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tbCandAddress, "");
            }
        }

        private void tbFacIdFK_Validating(object sender, CancelEventArgs e)
        {
            int facultyID;
            if (!int.TryParse(tbFacIdFK.Text, out facultyID))
            {
                errorProvider.SetError(tbFacIdFK, "Please enter a valid Faculty ID.");
            }
            else
            {
                errorProvider.SetError(tbFacIdFK, "");
            }
        }

        #endregion

        #region Custom Validation Method

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbCandFirstName.Text))
            {
                errorProvider.SetError(tbCandFirstName, "First name cannot be empty.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbCandFirstName, "");
            }

            if (string.IsNullOrWhiteSpace(tbCandLastName.Text))
            {
                errorProvider.SetError(tbCandLastName, "Last name cannot be empty.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbCandLastName, "");
            }

            if (string.IsNullOrWhiteSpace(tbCandAddress.Text))
            {
                errorProvider.SetError(tbCandAddress, "Address cannot be empty.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbCandAddress, "");
            }

            int facultyID;
            if (!int.TryParse(tbFacIdFK.Text, out facultyID))
            {
                errorProvider.SetError(tbFacIdFK, "Please enter a valid Faculty ID.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbFacIdFK, "");
            }

            return isValid;
        }

        #endregion

        #region KeyDown Event

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true; // Prevent default handling
            }
        }

        #endregion
    }
}
