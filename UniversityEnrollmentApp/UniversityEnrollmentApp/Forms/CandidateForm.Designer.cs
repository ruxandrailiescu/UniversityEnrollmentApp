namespace UniversityEnrollmentApp.Forms
{
    partial class CandidateForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateForm));
            this.nudCandID = new System.Windows.Forms.NumericUpDown();
            this.tbCandFirstName = new System.Windows.Forms.TextBox();
            this.tbCandLastName = new System.Windows.Forms.TextBox();
            this.dtpCandBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbCandAddress = new System.Windows.Forms.TextBox();
            this.checkBoxAccepted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveCand = new System.Windows.Forms.Button();
            this.btnUpdateCand = new System.Windows.Forms.Button();
            this.btnDeleteCand = new System.Windows.Forms.Button();
            this.btnClearCand = new System.Windows.Forms.Button();
            this.dataGridViewCand = new System.Windows.Forms.DataGridView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFacIdFK = new System.Windows.Forms.TextBox();
            this.toolStripCand = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCandID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCand)).BeginInit();
            this.toolStripCand.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudCandID
            // 
            this.nudCandID.Location = new System.Drawing.Point(180, 56);
            this.nudCandID.Name = "nudCandID";
            this.nudCandID.Size = new System.Drawing.Size(178, 20);
            this.nudCandID.TabIndex = 0;
            // 
            // tbCandFirstName
            // 
            this.tbCandFirstName.Location = new System.Drawing.Point(180, 93);
            this.tbCandFirstName.Name = "tbCandFirstName";
            this.tbCandFirstName.Size = new System.Drawing.Size(178, 20);
            this.tbCandFirstName.TabIndex = 1;
            // 
            // tbCandLastName
            // 
            this.tbCandLastName.Location = new System.Drawing.Point(180, 129);
            this.tbCandLastName.Name = "tbCandLastName";
            this.tbCandLastName.Size = new System.Drawing.Size(178, 20);
            this.tbCandLastName.TabIndex = 2;
            // 
            // dtpCandBirthDate
            // 
            this.dtpCandBirthDate.Location = new System.Drawing.Point(180, 165);
            this.dtpCandBirthDate.Name = "dtpCandBirthDate";
            this.dtpCandBirthDate.Size = new System.Drawing.Size(178, 20);
            this.dtpCandBirthDate.TabIndex = 3;
            // 
            // tbCandAddress
            // 
            this.tbCandAddress.Location = new System.Drawing.Point(180, 201);
            this.tbCandAddress.Name = "tbCandAddress";
            this.tbCandAddress.Size = new System.Drawing.Size(178, 20);
            this.tbCandAddress.TabIndex = 4;
            // 
            // checkBoxAccepted
            // 
            this.checkBoxAccepted.AutoSize = true;
            this.checkBoxAccepted.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAccepted.Location = new System.Drawing.Point(180, 273);
            this.checkBoxAccepted.Name = "checkBoxAccepted";
            this.checkBoxAccepted.Size = new System.Drawing.Size(82, 22);
            this.checkBoxAccepted.TabIndex = 5;
            this.checkBoxAccepted.Text = "Accepted";
            this.checkBoxAccepted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(68, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(68, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Birth Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(68, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(68, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status:";
            // 
            // btnSaveCand
            // 
            this.btnSaveCand.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnSaveCand.Location = new System.Drawing.Point(145, 458);
            this.btnSaveCand.Name = "btnSaveCand";
            this.btnSaveCand.Size = new System.Drawing.Size(75, 36);
            this.btnSaveCand.TabIndex = 13;
            this.btnSaveCand.Text = "&Save";
            this.btnSaveCand.UseVisualStyleBackColor = true;
            this.btnSaveCand.Click += new System.EventHandler(this.btnSaveCand_Click);
            // 
            // btnUpdateCand
            // 
            this.btnUpdateCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdateCand.Location = new System.Drawing.Point(283, 458);
            this.btnUpdateCand.Name = "btnUpdateCand";
            this.btnUpdateCand.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateCand.TabIndex = 14;
            this.btnUpdateCand.Text = "Update";
            this.btnUpdateCand.UseVisualStyleBackColor = true;
            this.btnUpdateCand.Click += new System.EventHandler(this.btnUpdateCand_Click);
            // 
            // btnDeleteCand
            // 
            this.btnDeleteCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnDeleteCand.Location = new System.Drawing.Point(421, 458);
            this.btnDeleteCand.Name = "btnDeleteCand";
            this.btnDeleteCand.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteCand.TabIndex = 15;
            this.btnDeleteCand.Text = "&Delete";
            this.btnDeleteCand.UseVisualStyleBackColor = true;
            this.btnDeleteCand.Click += new System.EventHandler(this.btnDeleteCand_Click);
            // 
            // btnClearCand
            // 
            this.btnClearCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnClearCand.Location = new System.Drawing.Point(559, 458);
            this.btnClearCand.Name = "btnClearCand";
            this.btnClearCand.Size = new System.Drawing.Size(75, 36);
            this.btnClearCand.TabIndex = 16;
            this.btnClearCand.Text = "Clear";
            this.btnClearCand.UseVisualStyleBackColor = true;
            this.btnClearCand.Click += new System.EventHandler(this.btnClearCand_Click);
            // 
            // dataGridViewCand
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.dataGridViewCand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.dataGridViewCand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCand.Location = new System.Drawing.Point(421, 56);
            this.dataGridViewCand.Name = "dataGridViewCand";
            this.dataGridViewCand.Size = new System.Drawing.Size(329, 360);
            this.dataGridViewCand.TabIndex = 17;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(278, 273);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 22);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Rejected";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(68, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Faculty ID:";
            // 
            // tbFacIdFK
            // 
            this.tbFacIdFK.Location = new System.Drawing.Point(180, 236);
            this.tbFacIdFK.Name = "tbFacIdFK";
            this.tbFacIdFK.Size = new System.Drawing.Size(178, 20);
            this.tbFacIdFK.TabIndex = 20;
            // 
            // toolStripCand
            // 
            this.toolStripCand.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLoad});
            this.toolStripCand.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripCand.Location = new System.Drawing.Point(0, 0);
            this.toolStripCand.Name = "toolStripCand";
            this.toolStripCand.Size = new System.Drawing.Size(828, 25);
            this.toolStripCand.TabIndex = 21;
            this.toolStripCand.Text = "toolStrip1";
            // 
            // toolStripBtnLoad
            // 
            this.toolStripBtnLoad.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripBtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLoad.Image")));
            this.toolStripBtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLoad.Name = "toolStripBtnLoad";
            this.toolStripBtnLoad.Size = new System.Drawing.Size(133, 22);
            this.toolStripBtnLoad.Text = "Load Candidates";
            this.toolStripBtnLoad.Click += new System.EventHandler(this.toolStripBtnLoad_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 526);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(828, 551);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripCand);
            this.Controls.Add(this.tbFacIdFK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewCand);
            this.Controls.Add(this.btnClearCand);
            this.Controls.Add(this.btnDeleteCand);
            this.Controls.Add(this.btnUpdateCand);
            this.Controls.Add(this.btnSaveCand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBoxAccepted);
            this.Controls.Add(this.tbCandAddress);
            this.Controls.Add(this.dtpCandBirthDate);
            this.Controls.Add(this.tbCandLastName);
            this.Controls.Add(this.tbCandFirstName);
            this.Controls.Add(this.nudCandID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CandidateForm";
            this.Text = "CandidateForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudCandID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCand)).EndInit();
            this.toolStripCand.ResumeLayout(false);
            this.toolStripCand.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCandID;
        private System.Windows.Forms.TextBox tbCandFirstName;
        private System.Windows.Forms.TextBox tbCandLastName;
        private System.Windows.Forms.DateTimePicker dtpCandBirthDate;
        private System.Windows.Forms.TextBox tbCandAddress;
        private System.Windows.Forms.CheckBox checkBoxAccepted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveCand;
        private System.Windows.Forms.Button btnUpdateCand;
        private System.Windows.Forms.Button btnDeleteCand;
        private System.Windows.Forms.Button btnClearCand;
        private System.Windows.Forms.DataGridView dataGridViewCand;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFacIdFK;
        private System.Windows.Forms.ToolStrip toolStripCand;
        private System.Windows.Forms.ToolStripButton toolStripBtnLoad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}