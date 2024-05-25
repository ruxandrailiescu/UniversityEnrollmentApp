namespace UniversityEnrollmentApp.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.donutChartControl1 = new ChartLibrary.DonutChartControl();
            this.SuspendLayout();
            // 
            // donutChartControl1
            // 
            this.donutChartControl1.Location = new System.Drawing.Point(206, 69);
            this.donutChartControl1.Name = "donutChartControl1";
            this.donutChartControl1.Size = new System.Drawing.Size(557, 394);
            this.donutChartControl1.TabIndex = 0;
            this.donutChartControl1.Text = "donutChartControl1";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(828, 551);
            this.Controls.Add(this.donutChartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartLibrary.DonutChartControl donutChartControl1;
    }
}