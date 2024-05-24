using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollmentApp.Entities
{
    public class Grade
    {
        public long GradeID { get; set; }
        public string CourseName { get; set; }
        public double CourseGrade { get; set; }
        public long CandidateID { get; set; }

        public Grade () { }

        public Grade(long gradeID, string courseName, double courseGrade, long candidateID) : this()
        {
            GradeID = gradeID;
            CourseName = courseName;
            CourseGrade = courseGrade;
            CandidateID = candidateID;
        }
    }
}
