namespace UniversityEnrollmentApp.Forms
{
    partial class FacultyForm
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
            this.dataGridViewFaculty = new System.Windows.Forms.DataGridView();
            this.btnClearCand = new System.Windows.Forms.Button();
            this.btnDeleteCand = new System.Windows.Forms.Button();
            this.btnUpdateCand = new System.Windows.Forms.Button();
            this.btnSaveCand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFacAddress = new System.Windows.Forms.TextBox();
            this.tbFacName = new System.Windows.Forms.TextBox();
            this.nudFacID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFacID)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFaculty
            // 
            this.dataGridViewFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculty.Location = new System.Drawing.Point(421, 56);
            this.dataGridViewFaculty.Name = "dataGridViewFaculty";
            this.dataGridViewFaculty.Size = new System.Drawing.Size(329, 360);
            this.dataGridViewFaculty.TabIndex = 35;
            // 
            // btnClearCand
            // 
            this.btnClearCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnClearCand.Location = new System.Drawing.Point(559, 458);
            this.btnClearCand.Name = "btnClearCand";
            this.btnClearCand.Size = new System.Drawing.Size(75, 36);
            this.btnClearCand.TabIndex = 34;
            this.btnClearCand.Text = "Clear";
            this.btnClearCand.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCand
            // 
            this.btnDeleteCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnDeleteCand.Location = new System.Drawing.Point(421, 458);
            this.btnDeleteCand.Name = "btnDeleteCand";
            this.btnDeleteCand.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteCand.TabIndex = 33;
            this.btnDeleteCand.Text = "Delete";
            this.btnDeleteCand.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCand
            // 
            this.btnUpdateCand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCand.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCand.ForeColor = System.Drawing.Color.Indigo;
            this.btnUpdateCand.Location = new System.Drawing.Point(283, 458);
            this.btnUpdateCand.Name = "btnUpdateCand";
            this.btnUpdateCand.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateCand.TabIndex = 32;
            this.btnUpdateCand.Text = "Update";
            this.btnUpdateCand.UseVisualStyleBackColor = true;
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
            this.btnSaveCand.TabIndex = 31;
            this.btnSaveCand.Text = "Save";
            this.btnSaveCand.UseVisualStyleBackColor = true;
            this.btnSaveCand.Click += new System.EventHandler(this.btnSaveCand_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(66, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Faculty Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(66, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            // 
            // tbFacAddress
            // 
            this.tbFacAddress.Location = new System.Drawing.Point(178, 126);
            this.tbFacAddress.Name = "tbFacAddress";
            this.tbFacAddress.Size = new System.Drawing.Size(178, 20);
            this.tbFacAddress.TabIndex = 22;
            // 
            // tbFacName
            // 
            this.tbFacName.Location = new System.Drawing.Point(178, 91);
            this.tbFacName.Name = "tbFacName";
            this.tbFacName.Size = new System.Drawing.Size(178, 20);
            this.tbFacName.TabIndex = 19;
            // 
            // nudFacID
            // 
            this.nudFacID.Location = new System.Drawing.Point(178, 56);
            this.nudFacID.Name = "nudFacID";
            this.nudFacID.Size = new System.Drawing.Size(178, 20);
            this.nudFacID.TabIndex = 18;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(828, 551);
            this.Controls.Add(this.dataGridViewFaculty);
            this.Controls.Add(this.btnClearCand);
            this.Controls.Add(this.btnDeleteCand);
            this.Controls.Add(this.btnUpdateCand);
            this.Controls.Add(this.btnSaveCand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFacAddress);
            this.Controls.Add(this.tbFacName);
            this.Controls.Add(this.nudFacID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFacID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFaculty;
        private System.Windows.Forms.Button btnClearCand;
        private System.Windows.Forms.Button btnDeleteCand;
        private System.Windows.Forms.Button btnUpdateCand;
        private System.Windows.Forms.Button btnSaveCand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFacAddress;
        private System.Windows.Forms.TextBox tbFacName;
        private System.Windows.Forms.NumericUpDown nudFacID;
    }
}