using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLibrary
{
    public partial class DonutChartControl : Control
    {
        private DonutChartValue[] _data;
        public DonutChartValue[] Data
        {
            get { return _data; }
            set
            {
                _data = value;
                Invalidate();
            }
        }
        private Color[] _colors;
        public Color[] Colors
        {
            get { return _colors; }
            set
            {
                _colors = value;
                Invalidate();
            }
        }
        public Font LabelFont { get; set; } = new Font("Sitka Small", 10);
        public Color LabelColor { get; set; } = Color.Black;
        public int LegendBoxSize { get; set; } = 20;
        public int LegendPadding { get; set; } = 10;

        public DonutChartControl()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.DonutChartControl_Paint);

            // redraws the chart if the control is resized
            ResizeRedraw = true;

            // default data
            Data = new[]
            {
                new DonutChartValue("Faculty A", 30),
                new DonutChartValue("Faculty B", 20),
                new DonutChartValue("Faculty C", 50)
            };

            // default colors
            Colors = new[]
            {
                Color.White, Color.Black, Color.Indigo, Color.Purple, Color.MediumPurple
            };
        }

        private void DonutChartControl_Paint(object sender, PaintEventArgs e)
        {
            // Get the drawing context
            Graphics graphics = e.Graphics;
            // Get the drawing area
            Rectangle clipRectangle = e.ClipRectangle;

            // Ensure the clipRectangle dimensions are valid
            if (clipRectangle.Width <= 0 || clipRectangle.Height <= 0 || Data == null || Data.Length == 0)
                return;

            // Calculate the total value of the data
            float totalValue = Data.Sum(d => d.Value);

            // Set the center and radius for the donut chart
            PointF center = new PointF(clipRectangle.Width / 3, clipRectangle.Height / 2);
            float radius = Math.Min(clipRectangle.Width / 2, clipRectangle.Height / 2) * 0.8f;
            float innerRadius = radius * 0.5f;

            // Ensure the radius dimensions are valid
            if (radius <= 0 || innerRadius <= 0)
                return;

            // Starting angle for the first slice
            float startAngle = 0;

            for (int i = 0; i < Data.Length; i++)
            {
                // Calculate the sweep angle for each slice
                float sweepAngle = (Data[i].Value / totalValue) * 360;

                using (Brush brush = new SolidBrush(Colors[i % Colors.Length]))
                {
                    // Draw the outer arc
                    graphics.FillPie(brush,
                        center.X - radius,
                        center.Y - radius,
                        2 * radius,
                        2 * radius,
                        startAngle,
                        sweepAngle);
                }

                // Draw the inner circle to create the donut effect
                using (Brush brush = new SolidBrush(this.BackColor))
                {
                    graphics.FillEllipse(brush,
                        center.X - innerRadius,
                        center.Y - innerRadius,
                        2 * innerRadius,
                        2 * innerRadius);
                }

                // Update the start angle for the next slice
                startAngle += sweepAngle;
            }

            // Draw the legend
            DrawLegend(graphics, clipRectangle);
        }

        private void DrawLegend(Graphics graphics, Rectangle clipRectangle)
        {
            int legendX = clipRectangle.Width - (LegendBoxSize + LegendPadding * 2 + 100); // Adjust for text width
            int legendY = LegendPadding;
            int boxSize = LegendBoxSize;

            for (int i = 0; i < Data.Length; i++)
            {
                using (Brush brush = new SolidBrush(Colors[i % Colors.Length]))
                {
                    // Draw legend color box
                    graphics.FillRectangle(brush, legendX, legendY, boxSize, boxSize);
                }

                // Draw legend text
                string legendText = $"{Data[i].Label}: {Data[i].Value}%";
                using (Brush textBrush = new SolidBrush(LabelColor))
                {
                    // Measure the string to adjust position
                    SizeF stringSize = graphics.MeasureString(legendText, LabelFont);
                    graphics.DrawString(legendText, LabelFont, textBrush, legendX + boxSize + LegendPadding, legendY + (boxSize - stringSize.Height) / 2);
                }

                // Update the Y position for the next legend item
                legendY += boxSize + LegendPadding;
            }
        }
    }
}
