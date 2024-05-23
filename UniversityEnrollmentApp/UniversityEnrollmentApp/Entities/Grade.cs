using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollmentApp.Entities
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string CourseName { get; set; }
        public double CourseGrade { get; set; }

        public Grade () { }

        public Grade(int gradeID, string courseName, double courseGrade) : this()
        {
            GradeID = gradeID;
            CourseName = courseName;
            CourseGrade = courseGrade;
        }
    }
}
