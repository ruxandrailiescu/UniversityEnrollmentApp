using ChartLibrary;
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
    public partial class DashboardForm : Form
    {
        public DonutChartControl donutChartControl2 {  get; set; }
        private FacultyForm facultyForm;
        private CandidateForm candidateForm;

        public DashboardForm()
        {
            InitializeComponent();
            donutChartControl2 = new DonutChartControl();
            this.Controls.Add(donutChartControl2);
            donutChartControl2.Dock = DockStyle.Fill;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Initialize FacultyForm and subscribe to the DataChanged event
            facultyForm = new FacultyForm();
            facultyForm.DataChanged += DataForm_DataChanged;

            candidateForm = new CandidateForm();
            candidateForm.DataChanged += DataForm_DataChanged;

            UpdateChart(); // Initial chart update with existing data
        }

        private void DataForm_DataChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private List<DonutChartValue> GenerateDonutChartData()
        {
            //var chartData = new List<DonutChartValue>();
            //var faculties = DataSource.Faculties;

            //int totalFaculties = faculties.Count;
            //if (totalFaculties == 0) return chartData; // Avoid division by zero

            //foreach (var faculty in faculties)
            //{
            //    var existingValue = chartData.FirstOrDefault(d => d.Label == faculty.FacultyName);
            //    if (existingValue != null)
            //    {
            //        existingValue.Value += 1; // Increment the count for this faculty
            //    }
            //    else
            //    {
            //        chartData.Add(new DonutChartValue(faculty.FacultyName, 1));
            //    }
            //}

            //// Calculate the percentage for each faculty
            //foreach (var data in chartData)
            //{
            //    data.Value = (float)Math.Round((data.Value / totalFaculties) * 100, 2);
            //}

            //return chartData;
            var chartData = new List<DonutChartValue>();
            var candidates = DataSource.Candidates;

            int totalCandidates = candidates.Count;
            if (totalCandidates == 0) return chartData;

            var facultyCounts = candidates
                .GroupBy(c => c.FacultyID)
                .Select(g => new { FacultyID = g.Key, Count = g.Count() })
                .ToList();

            foreach (var facultyCount in facultyCounts)
            {
                var faculty = DataSource.Faculties.FirstOrDefault(f => f.FacultyID == facultyCount.FacultyID);
                if (faculty != null)
                {
                    chartData.Add(new DonutChartValue(faculty.FacultyName, (float)Math.Round((double)facultyCount.Count / totalCandidates * 100, 2)));
                }
            }

            return chartData;
        }

        private void UpdateChart()
        {
            var chartData = GenerateDonutChartData();
            donutChartControl2.Data = chartData.ToArray();
            donutChartControl2.Invalidate();
        }
    }
}
