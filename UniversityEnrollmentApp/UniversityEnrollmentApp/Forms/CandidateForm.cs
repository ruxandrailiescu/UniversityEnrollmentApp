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
    public partial class CandidateForm : Form
    {
        #region Form Loading

        private List<Candidate> Candidates;
        public CandidateForm()
        {
            InitializeComponent();
            Candidates = new List<Candidate>();
        }

        #endregion

        #region Candidate Buttons

        private void btnSaveCand_Click(object sender, EventArgs e)
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
            Candidates.Add(candidate);
            dataGridViewCand.DataSource = null;
            dataGridViewCand.DataSource = Candidates;
        }

        #endregion
    }
}
