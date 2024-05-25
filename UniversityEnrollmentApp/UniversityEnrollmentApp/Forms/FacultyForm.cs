using ChartLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnrollmentApp.Entities;

namespace UniversityEnrollmentApp.Forms
{
    public partial class FacultyForm : Form
    {
        #region Form Loading

        private ErrorProvider errorProvider;
        private const string ConnectionString = "Data Source=database.db";

        public FacultyForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

            // Setup DataGridView for editing
            dataGridViewFaculty.AllowUserToAddRows = false;
            dataGridViewFaculty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFaculty.MultiSelect = false;
            dataGridViewFaculty.ReadOnly = false; // Allow editing
            dataGridViewFaculty.CellEndEdit += DataGridViewFaculty_CellEndEdit; // Handle cell edit end
            RefreshDataGrid();

            // Attach Validating events
            tbFacName.Validating += new CancelEventHandler(tbFacName_Validating);
            tbFacAddress.Validating += new CancelEventHandler(tbFacAddress_Validating);

            // Attach KeyDown event
            this.KeyPreview = true; // Allows the form to receive key events before the focused control
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        #endregion

        #region Faculty Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                Faculty faculty = new Faculty
                {
                    FacultyID = (long)nudFacID.Value,
                    FacultyName = tbFacName.Text,
                    FacultyAddress = tbFacAddress.Text,
                };
                try
                {
                    AddFacultyDB(faculty);      // save new faculty to the database
                    MessageBox.Show("Faculty saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                RefreshDataGrid();
                ClearInputControls();
            }
        }

        private void btnUpdateCand_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (dataGridViewFaculty.SelectedRows.Count > 0)
                {
                    int index = dataGridViewFaculty.SelectedRows[0].Index;
                    if(index >= 0 && index < DataSource.Faculties.Count)
                    {
                        DataSource.Faculties[index].FacultyID = (long)dataGridViewFaculty.Rows[index].Cells[0].Value;
                        DataSource.Faculties[index].FacultyName = dataGridViewFaculty.Rows[index].Cells[1].Value.ToString();
                        DataSource.Faculties[index].FacultyAddress = dataGridViewFaculty.Rows[index].Cells[2].Value.ToString();

                        Faculty faculty = DataSource.Faculties[index];
                        try
                        {
                            UpdateFacultyDB(faculty);   // update faculty in the database
                            MessageBox.Show("Faculty updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while updating the faculty: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearInputControls();
                }
                else
                {
                    MessageBox.Show("Please select a faculty to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteCand_Click(object sender, EventArgs e)
        {
            if (dataGridViewFaculty.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a faculty to delete.", "Delete Faculty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected faculty?", "Delete Faculty", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridViewFaculty.SelectedRows[0].Index;
                    if (index >= 0 && index < DataSource.Faculties.Count)
                    {
                        Faculty faculty = DataSource.Faculties[index];
                        DeleteFacultyDB(faculty);
                        RefreshDataGrid();
                        ClearInputControls();
                        MessageBox.Show("Faculty deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the faculty: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearCand_Click(object sender, EventArgs e)
        {
            // Clear the input controls
            ClearInputControls();
        }

        private void DataGridViewFaculty_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Update the Faculties list when a cell edit is ended
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < DataSource.Faculties.Count)
            {
                // Update the faculty in the local list
                DataSource.Faculties[rowIndex].FacultyID = (long)dataGridViewFaculty.Rows[rowIndex].Cells[0].Value;
                DataSource.Faculties[rowIndex].FacultyName = dataGridViewFaculty.Rows[rowIndex].Cells[1].Value.ToString();
                DataSource.Faculties[rowIndex].FacultyAddress = dataGridViewFaculty.Rows[rowIndex].Cells[2].Value.ToString();

                // Update the input controls with the new values
                nudFacID.Value = DataSource.Faculties[rowIndex].FacultyID;
                tbFacName.Text = DataSource.Faculties[rowIndex].FacultyName;
                tbFacAddress.Text = DataSource.Faculties[rowIndex].FacultyAddress;
            }
        }

        private void toolStripBtnLoad2_Click(object sender, EventArgs e)
        {
            LoadFacultiesDB();
            UpdateStatusLabel();
        }

        private void RefreshDataGrid()
        {
            dataGridViewFaculty.DataSource = null;
            dataGridViewFaculty.DataSource = DataSource.Faculties;
            UpdateStatusLabel();
        }

        private void ClearInputControls()
        {
            nudFacID.Value = 0;
            tbFacName.Clear();
            tbFacAddress.Clear();
            errorProvider.Clear();
        }

        #endregion

        #region ToolStrip

        private void UpdateStatusLabel()
        {
            int rowCount = dataGridViewFaculty.Rows.Count;
            // Subtract 1 if the last row is the 'new row' (if AllowUserToAddRows is true)
            if (dataGridViewFaculty.AllowUserToAddRows)
            {
                rowCount--;
            }
            toolStripLabel1.Text = $"Entries Count: {rowCount}";
        }

        #endregion

        #region Validation Events

        private void tbFacName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFacName.Text))
            {
                errorProvider.SetError(tbFacName, "Faculty name cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tbFacName, "");
            }
        }

        private void tbFacAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFacAddress.Text))
            {
                errorProvider.SetError(tbFacAddress, "Faculty address cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tbFacAddress, "");
            }
        }

        #endregion

        #region Custom Validation Method

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbFacName.Text))
            {
                errorProvider.SetError(tbFacName, "Faculty name cannot be empty.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbFacName, "");
            }

            if (string.IsNullOrWhiteSpace(tbFacAddress.Text))
            {
                errorProvider.SetError(tbFacAddress, "Faculty address cannot be empty.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbFacAddress, "");
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

        private void AddFacultyDB(Faculty faculty)
        {
            string query = "INSERT INTO Faculties(FacultyName, Address) "
                + "VALUES (@facultyName, @address); "
                + "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Add the new faculty to the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@facultyName", faculty.FacultyName);
                command.Parameters.AddWithValue("@address", faculty.FacultyAddress);

                faculty.FacultyID = (long)command.ExecuteScalar();

                // Add the new faculty to the local collection
                DataSource.Faculties.Add(faculty);
            }
        }

        private void LoadFacultiesDB()
        {
            const string query = "SELECT * FROM Faculties";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string facultyName = (string)reader["FacultyName"];
                        string address = (string)reader["Address"];

                        Faculty faculty = new Faculty(id, facultyName, address);
                        DataSource.Faculties.Add(faculty);
                    }
                }
            }
        }

        private void UpdateFacultyDB(Faculty faculty)
        {
            const string query = @"
                UPDATE Faculties 
                SET 
                    FacultyName = @facultyName,
                    Address = @address   
                WHERE 
                    Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", faculty.FacultyID);
                    command.Parameters.AddWithValue("@facultyName", faculty.FacultyName);
                    command.Parameters.AddWithValue("@address", faculty.FacultyAddress);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteFacultyDB(Faculty faculty)
        {
            const string query = "DELETE FROM Faculties WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Remove from the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", faculty.FacultyID);

                command.ExecuteNonQuery();

                // Remove from local copy
                DataSource.Faculties.Remove(faculty);
            }
        }

        #endregion

        #region DonutChart

        private List<DonutChartValue> GenerateDonutChartData()
        {
            var chartData = new List<DonutChartValue>();
            var faculties = DataSource.Faculties;

            // Calculate the total number of faculties
            int totalFaculties = faculties.Count;

            foreach (var faculty in faculties)
            {
                var existingValue = chartData.FirstOrDefault(d => d.Label == faculty.FacultyName);
                if (existingValue != null)
                {
                    existingValue.Value += 1; // Increment the count for this faculty
                }
                else
                {
                    chartData.Add(new DonutChartValue(faculty.FacultyName, 1));
                }
            }

            // Calculate the percentage for each faculty
            foreach (var data in chartData)
            {
                data.Value = (data.Value / totalFaculties) * 100;
            }

            return chartData;
        }

        // data binding to the DonutChartControl
        //private void UpdateChart()
        //{
        //    if (this.Owner is MainForm mainForm)
        //    {
        //        var chartData = GenerateDonutChartData();
        //        mainForm.DonutChartControl.Data = chartData.ToArray();
        //    }
        //}

        #endregion
    }
}
