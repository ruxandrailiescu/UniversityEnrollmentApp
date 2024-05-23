using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollmentApp.Entities
{
    public class Faculty
    {  
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
        public string FacultyAddress { get; set; }
        public List<Candidate> Candidates { get; set; }

        public Faculty()
        {   
            Candidates = new List<Candidate>();
        }

        public Faculty(int facultyID, string facultyName, string facultyAddress, List<Candidate> candidates) : this()
        {
            FacultyID = facultyID;
            FacultyName = facultyName;
            FacultyAddress = facultyAddress;
            Candidates = candidates;
        }
    }
}
