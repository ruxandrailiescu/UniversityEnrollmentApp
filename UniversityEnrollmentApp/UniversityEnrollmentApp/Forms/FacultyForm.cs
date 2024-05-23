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

        private List<Faculty> Faculties;
        public FacultyForm()
        {
            InitializeComponent();
            Faculties = new List<Faculty>();
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
            Faculties.Add(faculty);
            dataGridViewFaculty.DataSource = null;
            dataGridViewFaculty.DataSource = Faculties;
        }

        #endregion
    }
}
