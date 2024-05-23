using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public GradeForm()
        {
            InitializeComponent();
            Grades = new BindingList<Grade>();

            // Setup DataGridView for editing
            dataGridViewGrade.AllowUserToAddRows = false;
            dataGridViewGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrade.MultiSelect = false;
            dataGridViewGrade.ReadOnly = false; // Allow editing
            dataGridViewGrade.CellEndEdit += DataGridViewGrade_CellEndEdit; // Handle cell edit end
            RefreshDataGrid();
        }

        #endregion

        #region Grade Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
        {
            int candidateID;
            if (int.TryParse(tbCandIdFK.Text, out candidateID))
            {
                Candidate candidate = DataSource.Candidates.FirstOrDefault(c => c.CandidateID == candidateID);

                if (candidate != null)
                {
                    Grade grade = new Grade
                    {
                        GradeID = (int)nudGradeID.Value,
                        CourseName = tbCourseName.Text,
                        CourseGrade = (double)nudGrade.Value,
                        CandidateID = int.Parse(tbCandIdFK.Text),
                    };
                    Grades.Add(grade);
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Candidate not found. Please enter a valid Candidate ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Candidate ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearInputControls();
        }

        private void btnUpdateCand_Click(object sender, EventArgs e)
        {
            // Update the selected grade
            if (dataGridViewGrade.SelectedRows.Count > 0)
            {
                int index = dataGridViewGrade.SelectedRows[0].Index;
                if(index >= 0 && index < Grades.Count)
                {
                    Grades[index].GradeID = (int)dataGridViewGrade.Rows[index].Cells[0].Value;
                    Grades[index].CourseName = dataGridViewGrade.Rows[index].Cells[1].Value.ToString();
                    Grades[index].CourseGrade = (double)dataGridViewGrade.Rows[index].Cells[2].Value;
                    Grades[index].CandidateID = (int)dataGridViewGrade.Rows[index].Cells[3].Value;
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
                MessageBox.Show("Please select a grade to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCand_Click(object sender, EventArgs e)
        {
            // Delete the selected grade
            if (dataGridViewGrade.SelectedRows.Count > 0)
            {
                int index = dataGridViewGrade.SelectedRows[0].Index;
                Grades.RemoveAt(index);
                RefreshDataGrid();
                ClearInputControls();
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
                Grades[rowIndex].GradeID = (int)dataGridViewGrade.Rows[rowIndex].Cells[0].Value;
                Grades[rowIndex].CourseName = dataGridViewGrade.Rows[rowIndex].Cells[1].Value.ToString();
                Grades[rowIndex].CourseGrade = (double)dataGridViewGrade.Rows[rowIndex].Cells[2].Value;
                Grades[rowIndex].CandidateID = (int)dataGridViewGrade.Rows[rowIndex].Cells[3].Value;
            }
        }

        private void RefreshDataGrid()
        {
            dataGridViewGrade.DataSource = null;
            dataGridViewGrade.DataSource = Grades;
        }
        private void ClearInputControls()
        {
            nudGradeID.Value = 0;
            tbCourseName.Clear();
            nudGrade.Value = 0;
            tbCandIdFK.Clear();
        }

        #endregion
    }
}
