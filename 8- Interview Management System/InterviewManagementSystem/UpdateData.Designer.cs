namespace InterviewManagementSystem
{
    partial class UpdateData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateData));
            this.genderCheck = new System.Windows.Forms.PictureBox();
            this.skillsCheck = new System.Windows.Forms.PictureBox();
            this.ageCheck = new System.Windows.Forms.PictureBox();
            this.nameCheck = new System.Windows.Forms.PictureBox();
            this.btn_UpdateData = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.skillBox = new System.Windows.Forms.RichTextBox();
            this.lbl_Skills = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dgInterviewees = new System.Windows.Forms.DataGridView();
            this.idCheck = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.genderCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UpdateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // genderCheck
            // 
            this.genderCheck.Location = new System.Drawing.Point(546, 338);
            this.genderCheck.Name = "genderCheck";
            this.genderCheck.Size = new System.Drawing.Size(44, 22);
            this.genderCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genderCheck.TabIndex = 64;
            this.genderCheck.TabStop = false;
            // 
            // skillsCheck
            // 
            this.skillsCheck.Location = new System.Drawing.Point(546, 375);
            this.skillsCheck.Name = "skillsCheck";
            this.skillsCheck.Size = new System.Drawing.Size(44, 24);
            this.skillsCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skillsCheck.TabIndex = 63;
            this.skillsCheck.TabStop = false;
            // 
            // ageCheck
            // 
            this.ageCheck.Location = new System.Drawing.Point(329, 374);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(44, 25);
            this.ageCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ageCheck.TabIndex = 62;
            this.ageCheck.TabStop = false;
            // 
            // nameCheck
            // 
            this.nameCheck.Location = new System.Drawing.Point(329, 332);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(44, 26);
            this.nameCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameCheck.TabIndex = 61;
            this.nameCheck.TabStop = false;
            // 
            // btn_UpdateData
            // 
            this.btn_UpdateData.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateData.Image")));
            this.btn_UpdateData.Location = new System.Drawing.Point(614, 337);
            this.btn_UpdateData.Name = "btn_UpdateData";
            this.btn_UpdateData.Size = new System.Drawing.Size(100, 65);
            this.btn_UpdateData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_UpdateData.TabIndex = 60;
            this.btn_UpdateData.TabStop = false;
            this.btn_UpdateData.Click += new System.EventHandler(this.btn_UpdateData_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(171, 335);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.lbl_Name.TabIndex = 59;
            this.lbl_Name.Text = "Name:";
            // 
            // skillBox
            // 
            this.skillBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.skillBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillBox.ForeColor = System.Drawing.Color.White;
            this.skillBox.Location = new System.Drawing.Point(446, 374);
            this.skillBox.Name = "skillBox";
            this.skillBox.Size = new System.Drawing.Size(94, 25);
            this.skillBox.TabIndex = 58;
            this.skillBox.Text = "";
            // 
            // lbl_Skills
            // 
            this.lbl_Skills.AutoSize = true;
            this.lbl_Skills.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skills.ForeColor = System.Drawing.Color.White;
            this.lbl_Skills.Location = new System.Drawing.Point(392, 374);
            this.lbl_Skills.Name = "lbl_Skills";
            this.lbl_Skills.Size = new System.Drawing.Size(48, 20);
            this.lbl_Skills.TabIndex = 57;
            this.lbl_Skills.Text = "Skills:";
            // 
            // genderBox
            // 
            this.genderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.ForeColor = System.Drawing.Color.White;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(446, 335);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(94, 21);
            this.genderBox.TabIndex = 56;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(375, 338);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(65, 20);
            this.lbl_Gender.TabIndex = 55;
            this.lbl_Gender.Text = "Gender:";
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.ForeColor = System.Drawing.Color.White;
            this.ageBox.Location = new System.Drawing.Point(232, 373);
            this.ageBox.Multiline = true;
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(91, 24);
            this.ageBox.TabIndex = 54;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.ForeColor = System.Drawing.Color.White;
            this.lbl_Age.Location = new System.Drawing.Point(185, 371);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(41, 20);
            this.lbl_Age.TabIndex = 53;
            this.lbl_Age.Text = "Age:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(232, 334);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(91, 24);
            this.nameBox.TabIndex = 52;
            // 
            // dgInterviewees
            // 
            this.dgInterviewees.AllowUserToAddRows = false;
            this.dgInterviewees.AllowUserToDeleteRows = false;
            this.dgInterviewees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInterviewees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.Location = new System.Drawing.Point(12, 2);
            this.dgInterviewees.Name = "dgInterviewees";
            this.dgInterviewees.ReadOnly = true;
            this.dgInterviewees.Size = new System.Drawing.Size(704, 316);
            this.dgInterviewees.TabIndex = 51;
            // 
            // idCheck
            // 
            this.idCheck.Location = new System.Drawing.Point(100, 334);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(44, 26);
            this.idCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.idCheck.TabIndex = 67;
            this.idCheck.TabStop = false;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(12, 335);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(29, 20);
            this.idLabel.TabIndex = 66;
            this.idLabel.Text = "ID:";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.ForeColor = System.Drawing.Color.White;
            this.idBox.Location = new System.Drawing.Point(47, 334);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(47, 24);
            this.idBox.TabIndex = 65;
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(728, 410);
            this.Controls.Add(this.idCheck);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.genderCheck);
            this.Controls.Add(this.skillsCheck);
            this.Controls.Add(this.ageCheck);
            this.Controls.Add(this.nameCheck);
            this.Controls.Add(this.btn_UpdateData);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.skillBox);
            this.Controls.Add(this.lbl_Skills);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dgInterviewees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateData";
            this.Text = "UpdateData";
            this.Load += new System.EventHandler(this.UpdateData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_UpdateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox genderCheck;
        private System.Windows.Forms.PictureBox skillsCheck;
        private System.Windows.Forms.PictureBox ageCheck;
        private System.Windows.Forms.PictureBox nameCheck;
        private System.Windows.Forms.PictureBox btn_UpdateData;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.RichTextBox skillBox;
        private System.Windows.Forms.Label lbl_Skills;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DataGridView dgInterviewees;
        private System.Windows.Forms.PictureBox idCheck;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idBox;
    }
}