using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private const string ConnectionString = "Data Source=database.db";

        public CandidateForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

            // Setup DataGridView for editing
            dataGridViewCand.AllowUserToAddRows = false;
            dataGridViewCand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCand.MultiSelect = false;
            dataGridViewCand.ReadOnly = false; // Allow editing
            dataGridViewCand.CellEndEdit += DataGridViewCand_CellEndEdit; // Handle cell end edit
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
                long facultyID;
                if (long.TryParse(tbFacIdFK.Text, out facultyID))
                {
                    Faculty faculty = DataSource.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                    if (faculty != null)
                    {
                        Candidate candidate = new Candidate
                        {
                            CandidateID = (long)nudCandID.Value,     // no longer needed (auto-incrementable in the database)
                            CandidateFirstName = tbCandFirstName.Text,
                            CandidateLastName = tbCandLastName.Text,
                            CandidateBirthDate = dtpCandBirthDate.Value,
                            CandidateAddress = tbCandAddress.Text,
                            FacultyID = long.Parse(tbFacIdFK.Text),
                            ApplicationStatus = checkBoxAccepted.Checked ? true : false,
                        };
       
                        try
                        {
                            AddCandidateDB(candidate);      // save new candidate to the database
                            MessageBox.Show("Candidate saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

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
            if (ValidateForm())
            {
                // Update the selected candidate
                if (dataGridViewCand.SelectedRows.Count > 0)
                {
                    int index = dataGridViewCand.SelectedRows[0].Index;
                    if (index >= 0 && index < DataSource.Candidates.Count)
                    {
                        DataSource.Candidates[index].CandidateID = (long)dataGridViewCand.Rows[index].Cells[0].Value;
                        DataSource.Candidates[index].CandidateFirstName = dataGridViewCand.Rows[index].Cells[1].Value.ToString();
                        DataSource.Candidates[index].CandidateLastName = dataGridViewCand.Rows[index].Cells[2].Value.ToString();
                        DataSource.Candidates[index].CandidateBirthDate = (DateTime)dataGridViewCand.Rows[index].Cells[3].Value;
                        DataSource.Candidates[index].CandidateAddress = dataGridViewCand.Rows[index].Cells[4].Value.ToString();
                        DataSource.Candidates[index].ApplicationStatus = (bool)dataGridViewCand.Rows[index].Cells[5].Value;
                        DataSource.Candidates[index].FacultyID = (long)dataGridViewCand.Rows[index].Cells[6].Value;
                        
                        Candidate candidate = DataSource.Candidates[index];
                        try
                        {
                            UpdateCandidateDB(candidate);   // update candidate in the database
                            MessageBox.Show("Candidate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while updating the candidate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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
            if (dataGridViewCand.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a candidate to delete.", "Delete Candidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected candidate?", "Delete Candidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridViewCand.SelectedRows[0].Index;
                    if (index >= 0 && index < DataSource.Candidates.Count)
                    {
                        Candidate candidate = DataSource.Candidates[index];
                        DeleteCandidateDB(candidate);
                        RefreshDataGrid();
                        ClearInputControls();
                        MessageBox.Show("Candidate deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid candidate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the candidate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                // Update the candidate in the local list
                DataSource.Candidates[rowIndex].CandidateID = (long)dataGridViewCand.Rows[rowIndex].Cells[0].Value;
                DataSource.Candidates[rowIndex].CandidateFirstName = dataGridViewCand.Rows[rowIndex].Cells[1].Value.ToString();
                DataSource.Candidates[rowIndex].CandidateLastName = dataGridViewCand.Rows[rowIndex].Cells[2].Value.ToString();
                DataSource.Candidates[rowIndex].CandidateBirthDate = (DateTime)dataGridViewCand.Rows[rowIndex].Cells[3].Value;
                DataSource.Candidates[rowIndex].CandidateAddress = dataGridViewCand.Rows[rowIndex].Cells[4].Value.ToString();
                DataSource.Candidates[rowIndex].ApplicationStatus = (bool)dataGridViewCand.Rows[rowIndex].Cells[5].Value;
                DataSource.Candidates[rowIndex].FacultyID = (long)dataGridViewCand.Rows[rowIndex].Cells[6].Value;

                // Update the input controls with the new values
                nudCandID.Value = DataSource.Candidates[rowIndex].CandidateID;
                tbCandFirstName.Text = DataSource.Candidates[rowIndex].CandidateFirstName;
                tbCandLastName.Text = DataSource.Candidates[rowIndex].CandidateLastName;
                dtpCandBirthDate.Value = DataSource.Candidates[rowIndex].CandidateBirthDate;
                tbCandAddress.Text = DataSource.Candidates[rowIndex].CandidateAddress;
                checkBoxAccepted.Checked = DataSource.Candidates[rowIndex].ApplicationStatus;
                tbFacIdFK.Text = DataSource.Candidates[rowIndex].FacultyID.ToString();
            }
        }

        private void toolStripBtnLoad_Click(object sender, EventArgs e)
        {
            LoadCandidatesDB();
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
            long facultyID;
            if (!long.TryParse(tbFacIdFK.Text, out facultyID))
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

            long facultyID;
            if (!long.TryParse(tbFacIdFK.Text, out facultyID))
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

        #region Database Methods

        private void AddCandidateDB(Candidate candidate)
        {
            string query = "INSERT INTO Candidates(FirstName, LastName, BirthDate, Address, ApplicationStatus, " 
                + "FacultyId) VALUES (@firstName, @lastName, @birthDate, @address, @applicationStatus, @facultyId); "
                + "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Add the new candidate to the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", candidate.CandidateFirstName);
                command.Parameters.AddWithValue("@lastName", candidate.CandidateLastName);
                command.Parameters.AddWithValue("@birthDate", candidate.CandidateBirthDate);
                command.Parameters.AddWithValue("@address", candidate.CandidateAddress);
                command.Parameters.AddWithValue("@applicationStatus", (candidate.ApplicationStatus == true ? 1 : 0));
                command.Parameters.AddWithValue("@facultyId", candidate.FacultyID);

                candidate.CandidateID = (long)command.ExecuteScalar();

                // Add the new candidate to the local collection
                DataSource.Candidates.Add(candidate);
            }
        }

        private void LoadCandidatesDB()
        {
            const string query = "SELECT * FROM Candidates";

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        DateTime birthDate = DateTime.Parse((string)reader["BirthDate"]);
                        string address = (string)reader["Address"];
                        bool applicationStatus = (long)reader["ApplicationStatus"] == 1 ? true : false;
                        long facultyId = (long)reader["FacultyId"];

                        Candidate candidate = new Candidate(id, firstName, lastName, birthDate, address, applicationStatus, facultyId);
                        DataSource.Candidates.Add(candidate);
                    }
                }
            }
        }

        private void UpdateCandidateDB(Candidate candidate)
        {
            const string query = @"
                UPDATE Candidates 
                SET 
                    FirstName = @firstName,
                    LastName = @lastName,
                    BirthDate = @birthDate,
                    Address = @address,
                    ApplicationStatus = @status,
                    FacultyID = @facultyID
                WHERE 
                    Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", candidate.CandidateID);
                    command.Parameters.AddWithValue("@firstName", candidate.CandidateFirstName);
                    command.Parameters.AddWithValue("@lastName", candidate.CandidateLastName);
                    command.Parameters.AddWithValue("@birthDate", candidate.CandidateBirthDate);
                    command.Parameters.AddWithValue("@address", candidate.CandidateAddress);
                    command.Parameters.AddWithValue("@status", candidate.ApplicationStatus);
                    command.Parameters.AddWithValue("@facultyID", candidate.FacultyID);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteCandidateDB(Candidate candidate)
        {
            const string query = "DELETE FROM Candidates WHERE Id=@id";

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Remove from the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", candidate.CandidateID);

                command.ExecuteNonQuery();

                // Remove from local copy
                DataSource.Candidates.Remove(candidate);
            }
        }

        #endregion
    }
}