using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
    public partial class GradeForm : Form
    {
        #region Form Loading

        private BindingList<Grade> Grades;
        private ErrorProvider errorProvider;
        private const string ConnectionString = "Data Source=database.db";

        public GradeForm()
        {
            InitializeComponent();
            Grades = new BindingList<Grade>();
            errorProvider = new ErrorProvider();

            // Setup DataGridView for editing
            dataGridViewGrade.AllowUserToAddRows = false;
            dataGridViewGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrade.MultiSelect = false;
            dataGridViewGrade.ReadOnly = false; // Allow editing
            dataGridViewGrade.CellEndEdit += DataGridViewGrade_CellEndEdit; // Handle cell edit end
            RefreshDataGrid();

            // Attach Validating events
            tbCourseName.Validating += new CancelEventHandler(tbCourseName_Validating);
            tbCandIdFK.Validating += new CancelEventHandler(tbCandIdFK_Validating);

            // Attach KeyDown event
            this.KeyPreview = true; // Allows the form to receive key events before the focused control
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        #endregion

        #region Grade Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                long candidateID;
                if (long.TryParse(tbCandIdFK.Text, out candidateID))
                {
                    Candidate candidate = DataSource.Candidates.FirstOrDefault(c => c.CandidateID == candidateID);

                    if (candidate != null)
                    {
                        Grade grade = new Grade
                        {
                            GradeID = (long)nudGradeID.Value,
                            CourseName = tbCourseName.Text,
                            CourseGrade = (double)nudGrade.Value,
                            CandidateID = long.Parse(tbCandIdFK.Text),
                        };
                        try
                        {
                            AddGradeDB(grade);      // save new grade to the database
                            MessageBox.Show("Grade saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Candidate not found. Please enter a valid Candidate ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid grade to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearInputControls();
            }
        }

        private void btnUpdateCand_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                // Update the selected grade
                if (dataGridViewGrade.SelectedRows.Count > 0)
                {
                    int index = dataGridViewGrade.SelectedRows[0].Index;
                    if (index >= 0 && index < Grades.Count)
                    {
                        Grades[index].GradeID = (long)dataGridViewGrade.Rows[index].Cells[0].Value;
                        Grades[index].CourseName = dataGridViewGrade.Rows[index].Cells[1].Value.ToString();
                        Grades[index].CourseGrade = (double)dataGridViewGrade.Rows[index].Cells[2].Value;
                        Grades[index].CandidateID = (long)dataGridViewGrade.Rows[index].Cells[3].Value;

                        Grade grade = Grades[index];
                        try
                        {
                            UpdateGradeDB(grade);   // update grade in the database
                            MessageBox.Show("Grade updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while updating the grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearInputControls();
                }
                else
                {
                    MessageBox.Show("Please select a grade to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteCand_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrade.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade to delete.", "Delete Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected grade?", "Delete Grade", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int index = dataGridViewGrade.SelectedRows[0].Index;
                    if (index >= 0 && index < Grades.Count)
                    {
                        Grade grade = Grades[index];
                        DeleteGradeDB(grade);
                        RefreshDataGrid();
                        ClearInputControls();
                        MessageBox.Show("Grade deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearCand_Click(object sender, EventArgs e)
        {
            // Clear the input controls
            ClearInputControls();
        }

        private void DataGridViewGrade_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Update the Grades list when a cell edit is ended
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < Grades.Count)
            {
                // Update the grade in the local list
                Grades[rowIndex].GradeID = (long)dataGridViewGrade.Rows[rowIndex].Cells[0].Value;
                Grades[rowIndex].CourseName = dataGridViewGrade.Rows[rowIndex].Cells[1].Value.ToString();
                Grades[rowIndex].CourseGrade = (double)dataGridViewGrade.Rows[rowIndex].Cells[2].Value;
                Grades[rowIndex].CandidateID = (long)dataGridViewGrade.Rows[rowIndex].Cells[3].Value;

                // Update the input controls with the new values
                nudGradeID.Value = Grades[rowIndex].GradeID;
                tbCourseName.Text = Grades[rowIndex].CourseName;
                nudGrade.Value = (decimal)Grades[rowIndex].CourseGrade;
                tbCandIdFK.Text = Grades[rowIndex].CandidateID.ToString();
            }
        }

        private void toolStripBtnLoad1_Click(object sender, EventArgs e)
        {
            LoadGradesDB();
            UpdateStatusLabel();
        }

        private void btnSerializeGrades_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream stream = File.Create("transcripts.bin"))
                    formatter.Serialize(stream, Grades);
                MessageBox.Show("Grades serialized successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while serializing the grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeserializeGrades_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("transcripts.bin"))
            {
                Grades = (BindingList<Grade>)formatter.Deserialize(stream);
                RefreshDataGrid();
            }
        }

        private void btnExportGrades_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // When compiled, this code in this approach is converted to: try{} finally{}
                using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))
                // Equivalent to:
                // using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("CourseName,CourseGrade,CandidateId");

                    foreach (var grade in Grades)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\""
                                    , grade.CourseName.Replace("\"", "\"\"")
                                    , grade.CourseGrade.ToString()
                                    , grade.CandidateID.ToString());
                    }
                }
            }
        }

        private void RefreshDataGrid()
        {
            dataGridViewGrade.DataSource = null;
            dataGridViewGrade.DataSource = Grades;
            UpdateStatusLabel();
        }
        private void ClearInputControls()
        {
            nudGradeID.Value = 0;
            tbCourseName.Clear();
            nudGrade.Value = 0;
            tbCandIdFK.Clear();
            errorProvider.Clear();
        }

        #endregion

        #region ToolStrip

        private void UpdateStatusLabel()
        {
            int rowCount = dataGridViewGrade.Rows.Count;
            // Subtract 1 if the last row is the 'new row' (if AllowUserToAddRows is true)
            if (dataGridViewGrade.AllowUserToAddRows)
            {
                rowCount--;
            }
            toolStripLabel1.Text = $"Entries Count: {rowCount}";
        }

        #endregion

        #region Validation Events

        private void tbCourseName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCourseName.Text))
            {
                errorProvider.SetError(tbCourseName, "Course name cannot be empty.");
            }
            else
            {
                errorProvider.SetError(tbCourseName, "");
            }
        }

        private void tbCandIdFK_Validating(object sender, CancelEventArgs e)
        {
            long candidateID;
            if (!long.TryParse(tbCandIdFK.Text, out candidateID))
            {
                errorProvider.SetError(tbCandIdFK, "Please enter a valid Candidate ID.");
            }
            else
            {
                errorProvider.SetError(tbCandIdFK, "");
            }
        }

        #endregion

        #region Custom Validation Method

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(tbCourseName.Text))
            {
                errorProvider.SetError(tbCourseName, "Course name cannot be empty.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbCourseName, "");
            }

            long candidateID;
            if (!long.TryParse(tbCandIdFK.Text, out candidateID))
            {
                errorProvider.SetError(tbCandIdFK, "Please enter a valid Candidate ID.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(tbCandIdFK, "");
            }

            return isValid;
        }

        #endregion

        #region KeyDown Event & Alt Shortcuts

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true; // Prevent default handling
            }

            if (e.Alt && e.KeyCode == Keys.S)
            {
                btnSaveCand_Click(sender, e);
                return;
            }

            if (e.Alt && e.KeyCode == Keys.U)
            {
                btnUpdateCand_Click(sender, e);
                return;
            }

            if (e.Alt && e.KeyCode == Keys.D)
            {
                btnDeleteCand_Click(sender, e);
                return;
            }

            if (e.Alt && e.KeyCode == Keys.C)
            {
                btnClearCand_Click(sender, e);
                return;
            }
        }

        #endregion

        #region Database Methods

        private void AddGradeDB(Grade grade)
        {
            string query = "INSERT INTO Grades(CourseName, CourseGrade, CandidateId) "
                + "VALUES (@courseName, @courseGrade, @candidateId); "
                + "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Add the new grade to the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@courseName", grade.CourseName);
                command.Parameters.AddWithValue("@courseGrade", grade.CourseGrade);
                command.Parameters.AddWithValue("@candidateId", grade.CandidateID);

                grade.GradeID = (long)command.ExecuteScalar();

                // Add the new grade to the local collection
                Grades.Add(grade);
            }
        }

        private void LoadGradesDB()
        {
            const string query = "SELECT * FROM Grades";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string courseName = (string)reader["CourseName"];
                        double courseGrade = (double)reader["CourseGrade"];
                        long candidateId = (long)reader["CandidateId"];

                        Grade grade = new Grade(id, courseName, courseGrade, candidateId);
                        Grades.Add(grade);
                    }
                }
            }
        }

        private void UpdateGradeDB(Grade grade)
        {
            const string query = @"
                UPDATE Grades 
                SET 
                    CourseName = @courseName,
                    CourseGrade = @courseGrade,
                    CandidateId = @candidateId    
                WHERE 
                    Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", grade.GradeID);
                    command.Parameters.AddWithValue("@courseName", grade.CourseName);
                    command.Parameters.AddWithValue("@courseGrade", grade.CourseGrade);
                    command.Parameters.AddWithValue("@candidateId", grade.CandidateID);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteGradeDB(Grade grade)
        {
            const string query = "DELETE FROM Grades WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Remove from the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", grade.GradeID);

                command.ExecuteNonQuery();

                // Remove from local copy
                Grades.Remove(grade);
            }
        }

        #endregion

    }
}
