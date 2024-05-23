namespace UniversityEnrollmentApp.Forms
{
    partial class GradeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewGrade = new System.Windows.Forms.DataGridView();
            this.btnClearCand = new System.Windows.Forms.Button();
            this.btnDeleteCand = new System.Windows.Forms.Button();
            this.btnUpdateCand = new System.Windows.Forms.Button();
            this.btnSaveCand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.nudGradeID = new System.Windows.Forms.NumericUpDown();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCandIdFK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrade
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGrade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.dataGridViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrade.Location = new System.Drawing.Point(426, 56);
            this.dataGridViewGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewGrade.Name = "dataGridViewGrade";
            this.dataGridViewGrade.Size = new System.Drawing.Size(329, 360);
            this.dataGridViewGrade.TabIndex = 35;
            // 
            // btnClearCand
            // 
            this.btnClearCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnClearCand.Location = new System.Drawing.Point(564, 458);
            this.btnClearCand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearCand.Name = "btnClearCand";
            this.btnClearCand.Size = new System.Drawing.Size(76, 36);
            this.btnClearCand.TabIndex = 34;
            this.btnClearCand.Text = "Clear";
            this.btnClearCand.UseVisualStyleBackColor = true;
            this.btnClearCand.Click += new System.EventHandler(this.btnClearCand_Click);
            // 
            // btnDeleteCand
            // 
            this.btnDeleteCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnDeleteCand.Location = new System.Drawing.Point(426, 458);
            this.btnDeleteCand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCand.Name = "btnDeleteCand";
            this.btnDeleteCand.Size = new System.Drawing.Size(76, 36);
            this.btnDeleteCand.TabIndex = 33;
            this.btnDeleteCand.Text = "&Delete";
            this.btnDeleteCand.UseVisualStyleBackColor = true;
            this.btnDeleteCand.Click += new System.EventHandler(this.btnDeleteCand_Click);
            // 
            // btnUpdateCand
            // 
            this.btnUpdateCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdateCand.Location = new System.Drawing.Point(288, 458);
            this.btnUpdateCand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateCand.Name = "btnUpdateCand";
            this.btnUpdateCand.Size = new System.Drawing.Size(76, 36);
            this.btnUpdateCand.TabIndex = 32;
            this.btnUpdateCand.Text = "Update";
            this.btnUpdateCand.UseVisualStyleBackColor = true;
            this.btnUpdateCand.Click += new System.EventHandler(this.btnUpdateCand_Click);
            // 
            // btnSaveCand
            // 
            this.btnSaveCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnSaveCand.Location = new System.Drawing.Point(150, 458);
            this.btnSaveCand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveCand.Name = "btnSaveCand";
            this.btnSaveCand.Size = new System.Drawing.Size(76, 36);
            this.btnSaveCand.TabIndex = 31;
            this.btnSaveCand.Text = "&Save";
            this.btnSaveCand.UseVisualStyleBackColor = true;
            this.btnSaveCand.Click += new System.EventHandler(this.btnSaveCand_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(73, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Course Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(73, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(185, 93);
            this.tbCourseName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(178, 20);
            this.tbCourseName.TabIndex = 19;
            // 
            // nudGradeID
            // 
            this.nudGradeID.Location = new System.Drawing.Point(185, 56);
            this.nudGradeID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudGradeID.Name = "nudGradeID";
            this.nudGradeID.Size = new System.Drawing.Size(178, 20);
            this.nudGradeID.TabIndex = 18;
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(185, 132);
            this.nudGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(178, 20);
            this.nudGrade.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(73, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Candidate ID:";
            // 
            // tbCandIdFK
            // 
            this.tbCandIdFK.Location = new System.Drawing.Point(185, 173);
            this.tbCandIdFK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCandIdFK.Name = "tbCandIdFK";
            this.tbCandIdFK.Size = new System.Drawing.Size(178, 20);
            this.tbCandIdFK.TabIndex = 37;
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(828, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCandIdFK);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.dataGridViewGrade);
            this.Controls.Add(this.btnClearCand);
            this.Controls.Add(this.btnDeleteCand);
            this.Controls.Add(this.btnUpdateCand);
            this.Controls.Add(this.btnSaveCand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.nudGradeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrade;
        private System.Windows.Forms.Button btnClearCand;
        private System.Windows.Forms.Button btnDeleteCand;
        private System.Windows.Forms.Button btnUpdateCand;
        private System.Windows.Forms.Button btnSaveCand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.NumericUpDown nudGradeID;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCandIdFK;
    }
}