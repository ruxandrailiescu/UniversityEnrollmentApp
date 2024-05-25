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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeForm));
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
            this.toolStripCand = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnLoad1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.toolStripCand.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGrade
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
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
            // toolStripCand
            // 
            this.toolStripCand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLoad1});
            this.toolStripCand.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripCand.Location = new System.Drawing.Point(0, 0);
            this.toolStripCand.Name = "toolStripCand";
            this.toolStripCand.Size = new System.Drawing.Size(920, 25);
            this.toolStripCand.TabIndex = 39;
            this.toolStripCand.Text = "toolStrip1";
            // 
            // toolStripBtnLoad1
            // 
            this.toolStripBtnLoad1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnLoad1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripBtnLoad1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLoad1.Image")));
            this.toolStripBtnLoad1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLoad1.Name = "toolStripBtnLoad1";
            this.toolStripBtnLoad1.Size = new System.Drawing.Size(107, 22);
            this.toolStripBtnLoad1.Text = "Load Grades";
            this.toolStripBtnLoad1.Click += new System.EventHandler(this.toolStripBtnLoad1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 26);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeBinary,
            this.btnDeserializeBinary,
            this.btnExport});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeGrades});
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(180, 22);
            this.btnSerializeBinary.Text = "Serialize";
            // 
            // btnSerializeGrades
            // 
            this.btnSerializeGrades.Name = "btnSerializeGrades";
            this.btnSerializeGrades.Size = new System.Drawing.Size(180, 22);
            this.btnSerializeGrades.Text = "Transcript";
            this.btnSerializeGrades.Click += new System.EventHandler(this.btnSerializeGrades_Click);
            // 
            // btnDeserializeBinary
            // 
            this.btnDeserializeBinary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeserializeGrades});
            this.btnDeserializeBinary.Name = "btnDeserializeBinary";
            this.btnDeserializeBinary.Size = new System.Drawing.Size(180, 22);
            this.btnDeserializeBinary.Text = "Deserialize";
            // 
            // btnDeserializeGrades
            // 
            this.btnDeserializeGrades.Name = "btnDeserializeGrades";
            this.btnDeserializeGrades.Size = new System.Drawing.Size(180, 22);
            this.btnDeserializeGrades.Text = "Transcript";
            this.btnDeserializeGrades.Click += new System.EventHandler(this.btnDeserializeGrades_Click);
            // 
            // btnExport
            // 
            this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportGrades});
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 22);
            this.btnExport.Text = "Export";
            // 
            // btnExportGrades
            // 
            this.btnExportGrades.Name = "btnExportGrades";
            this.btnExportGrades.Size = new System.Drawing.Size(180, 22);
            this.btnExportGrades.Text = "Transcript";
            this.btnExportGrades.Click += new System.EventHandler(this.btnExportGrades_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStripCand);
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
            this.toolStripCand.ResumeLayout(false);
            this.toolStripCand.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStripCand;
        private System.Windows.Forms.ToolStripButton toolStripBtnLoad1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeGrades;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeGrades;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnExportGrades;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}