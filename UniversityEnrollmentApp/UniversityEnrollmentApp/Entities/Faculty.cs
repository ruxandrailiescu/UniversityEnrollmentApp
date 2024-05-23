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

        public Faculty() { }

        public Faculty(int facultyID, string facultyName, string facultyAddress) : this()
        {
            FacultyID = facultyID;
            FacultyName = facultyName;
            FacultyAddress = facultyAddress;
        }
    }
}
