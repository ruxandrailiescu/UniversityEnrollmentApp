using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLibrary
{
    public class DonutChartValue
    {
        public string Label { get; set; }
        public float Value { get; set; }

        public DonutChartValue(string label, float value)
        {
            Label = label;
            Value = value;
        }
    }
}
