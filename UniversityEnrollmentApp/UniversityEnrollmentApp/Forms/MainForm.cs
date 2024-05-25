using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityEnrollmentApp.Forms
{
    public partial class MainForm : Form
    {
        #region Form Loading

        private FacultyForm facultyForm;
        private CandidateForm candidateForm;
        private GradeForm gradeForm;
        private DashboardForm dashboardForm;

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;     // Set the form as an MDI container
            sidePanel.Height = btnFaculties.Height;
            sidePanel.Top = btnFaculties.Top;
            if (facultyForm == null || facultyForm.IsDisposed)
            {
                facultyForm = new FacultyForm();
                facultyForm.MdiParent = this;
                facultyForm.FormClosed += (s, args) => facultyForm = null; // Handle form closed event
                facultyForm.Show();
            }
            facultyForm.TopLevel = false;
            facultyForm.FormBorderStyle = FormBorderStyle.None;
            facultyForm.Dock = DockStyle.Fill;
            facultyForm.BringToFront();
        }

        #endregion

        #region Buttons

        private void btnFaculties_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnFaculties.Height;
            sidePanel.Top = btnFaculties.Top;
            if (facultyForm == null || facultyForm.IsDisposed)
            {
                facultyForm = new FacultyForm();
                facultyForm.MdiParent = this;
                facultyForm.FormClosed += (s, args) => facultyForm = null; // Handle form closed event
                facultyForm.Show();
            }
            facultyForm.TopLevel = false;
            facultyForm.FormBorderStyle = FormBorderStyle.None;
            facultyForm.Dock = DockStyle.Fill;
            facultyForm.BringToFront();
        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnCandidates.Height;
            sidePanel.Top = btnCandidates.Top;
            if(candidateForm == null || candidateForm.IsDisposed)
            {
                candidateForm = new CandidateForm();
                candidateForm.MdiParent = this;
                candidateForm.FormClosed += (s, args) => candidateForm = null; // Handle form closed event
                candidateForm.Show();
            }
            candidateForm.TopLevel = false;
            candidateForm.FormBorderStyle = FormBorderStyle.None;
            candidateForm.Dock = DockStyle.Fill;
            candidateForm.BringToFront();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnGrades.Height;
            sidePanel.Top = btnGrades.Top;
            if (gradeForm == null || gradeForm.IsDisposed)
            {
                gradeForm = new GradeForm();
                gradeForm.MdiParent = this;
                gradeForm.FormClosed += (s, args) => gradeForm = null; // Handle form closed event
                gradeForm.Show();
            }
            gradeForm.TopLevel = false;
            gradeForm.FormBorderStyle = FormBorderStyle.None;
            gradeForm.Dock = DockStyle.Fill;
            gradeForm.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnDashboard.Height;
            sidePanel.Top = btnDashboard.Top;
            if (dashboardForm == null || dashboardForm.IsDisposed)
            {
                dashboardForm = new DashboardForm();
                dashboardForm.MdiParent = this;
                dashboardForm.FormClosed += (s, args) => dashboardForm = null; // Handle form closed event
                dashboardForm.Show();
            }
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            dashboardForm.BringToFront();
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            string linkedinUrl = "https://www.linkedin.com/in/ruxandra-iliescu/";
            Process.Start(new ProcessStartInfo
            {
                FileName = linkedinUrl,
                UseShellExecute = true,
            });
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/ruxandrailiescu/UniversityEnrollmentApp";
            Process.Start(new ProcessStartInfo
            {
                FileName = githubUrl,
                UseShellExecute = true,
            });
        }

        private void pbShutdown_Click(object sender, EventArgs e)
        {
            // Confirm if the user really wants to close the application
            var result = MessageBox.Show("Are you sure you want to shutdown the application?", "Confirm Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Exit the application
                Application.Exit();
            }
        }

        #endregion
    }
}
