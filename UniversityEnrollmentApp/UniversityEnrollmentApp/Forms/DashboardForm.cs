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

namespace UniversityEnrollmentApp.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Set custom data
            donutChartControl1.Data = new[]
            {
            new DonutChartValue("Faculty A", 30),
            new DonutChartValue("Faculty B", 40),
            new DonutChartValue("Faculty C", 20),
            new DonutChartValue("Faculty D", 10)
            };
        }
    }
}
