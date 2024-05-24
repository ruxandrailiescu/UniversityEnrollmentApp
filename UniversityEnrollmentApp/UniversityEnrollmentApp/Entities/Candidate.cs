using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollmentApp.Entities
{
    public class Candidate
    {
        public long CandidateID { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public DateTime CandidateBirthDate { get; set; }
        public string CandidateAddress { get; set; }
        public bool ApplicationStatus {  get; set; }
        public long FacultyID { get; set; }

        public Candidate()
        {
            CandidateBirthDate = DateTime.Now;
        }

        public Candidate(long candidateID, string candidateFirstName, string candidateLastName, DateTime candidateBirthDate, string candidateAddress, bool applicationStatus, long facultyID) : this()
        {
            CandidateID = candidateID;
            CandidateFirstName = candidateFirstName;
            CandidateLastName = candidateLastName;
            CandidateBirthDate = candidateBirthDate;
            CandidateAddress = candidateAddress;
            ApplicationStatus = applicationStatus;
            FacultyID = facultyID;
        }
    }
}
