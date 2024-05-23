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

        private List<Grade> Grades;
        public GradeForm()
        {
            InitializeComponent();
            Grades = new List<Grade>();
        }

        #endregion

        #region Grade Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
        {
            Grade grade = new Grade
            {
                GradeID = (int)nudGradeID.Value,
                CourseName = tbCourseName.Text,
                CourseGrade = (double)nudGrade.Value,
                CandidateID = int.Parse(tbCandIdFK.Text),
            };
            Grades.Add(grade);
            dataGridViewGrade.DataSource = null;
            dataGridViewGrade.DataSource = Grades;
        }

        #endregion
    }
}
