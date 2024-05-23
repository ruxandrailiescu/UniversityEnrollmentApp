using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollmentApp.Entities
{
    public static class DataSource
    {
        public static BindingList<Candidate> Candidates { get; } = new BindingList<Candidate>();
        public static BindingList<Faculty> Faculties { get; } = new BindingList<Faculty>();
    }
}
