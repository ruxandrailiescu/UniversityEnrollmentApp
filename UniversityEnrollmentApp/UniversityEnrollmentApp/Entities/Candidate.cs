using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollmentApp.Entities
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public DateTime CandidateBirthDate { get; set; }
        public string CandidateAddress { get; set; }
        public List<Grade> Grades { get; set; }
        public bool ApplicationStatus {  get; set; }

        public Candidate()
        {
            Grades = new List<Grade>();
            CandidateBirthDate = DateTime.Now;
        }

        public Candidate(int candidateID, string candidateFirstName, string candidateLastName, DateTime candidateBirthDate, string candidateAddress, List<Grade> grades, bool applicationStatus) : this()
        {
            CandidateID = candidateID;
            CandidateFirstName = candidateFirstName;
            CandidateLastName = candidateLastName;
            CandidateBirthDate = candidateBirthDate;
            CandidateAddress = candidateAddress;
            Grades = grades;
            ApplicationStatus = applicationStatus;
        }
    }
}
