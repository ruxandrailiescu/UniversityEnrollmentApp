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
    public partial class FacultyForm : Form
    {
        #region Form Loading

        public FacultyForm()
        {
            InitializeComponent();

            // Setup DataGridView for editing
            dataGridViewFaculty.AllowUserToAddRows = false;
            dataGridViewFaculty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFaculty.MultiSelect = false;
            dataGridViewFaculty.ReadOnly = false; // Allow editing
            dataGridViewFaculty.CellEndEdit += DataGridViewFaculty_CellEndEdit; // Handle cell edit end
            RefreshDataGrid();
        }

        #endregion

        #region Faculty Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty
            {
                FacultyID = (int)nudFacID.Value,
                FacultyName = tbFacName.Text,
                FacultyAddress = tbFacAddress.Text,
            };
            DataSource.Faculties.Add(faculty);
            RefreshDataGrid();
            ClearInputControls();
        }

        private void btnUpdateCand_Click(object sender, EventArgs e)
        {
            if (dataGridViewFaculty.SelectedRows.Count > 0)
            {
                int index = dataGridViewFaculty.SelectedRows[0].Index;
                DataSource.Faculties[index].FacultyID = (int)dataGridViewFaculty.Rows[index].Cells[0].Value;
                DataSource.Faculties[index].FacultyName = dataGridViewFaculty.Rows[index].Cells[1].Value.ToString();
                DataSource.Faculties[index].FacultyAddress = dataGridViewFaculty.Rows[index].Cells[2].Value.ToString();
                RefreshDataGrid();
                ClearInputControls();
            }
        }

        private void btnDeleteCand_Click(object sender, EventArgs e)
        {
            // Delete the selected faculty
            if (dataGridViewFaculty.SelectedRows.Count > 0)
            {
                int index = dataGridViewFaculty.SelectedRows[0].Index;
                DataSource.Faculties.RemoveAt(index);
                RefreshDataGrid();
                ClearInputControls();
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
                DataSource.Faculties[rowIndex].FacultyID = (int)dataGridViewFaculty.Rows[rowIndex].Cells[0].Value;
                DataSource.Faculties[rowIndex].FacultyName = dataGridViewFaculty.Rows[rowIndex].Cells[1].Value.ToString();
                DataSource.Faculties[rowIndex].FacultyAddress = dataGridViewFaculty.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }
        private void RefreshDataGrid()
        {
            dataGridViewFaculty.DataSource = null;
            dataGridViewFaculty.DataSource = DataSource.Faculties;
        }

        private void ClearInputControls()
        {
            nudFacID.Value = 0;
            tbFacName.Clear();
            tbFacAddress.Clear();
        }

        #endregion
    }
}
