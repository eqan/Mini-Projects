namespace InterviewManagementSystem
{
    partial class AddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddData));
            this.dgInterviewees = new System.Windows.Forms.DataGridView();
            this.btn_AddData = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.skillBox = new System.Windows.Forms.RichTextBox();
            this.lbl_Skills = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameCheck = new System.Windows.Forms.PictureBox();
            this.ageCheck = new System.Windows.Forms.PictureBox();
            this.skillsCheck = new System.Windows.Forms.PictureBox();
            this.genderCheck = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInterviewees
            // 
            this.dgInterviewees.AllowUserToAddRows = false;
            this.dgInterviewees.AllowUserToDeleteRows = false;
            this.dgInterviewees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInterviewees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.Location = new System.Drawing.Point(26, 12);
            this.dgInterviewees.Name = "dgInterviewees";
            this.dgInterviewees.ReadOnly = true;
            this.dgInterviewees.Size = new System.Drawing.Size(707, 316);
            this.dgInterviewees.TabIndex = 34;
            // 
            // btn_AddData
            // 
            this.btn_AddData.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddData.Image")));
            this.btn_AddData.Location = new System.Drawing.Point(617, 338);
            this.btn_AddData.Name = "btn_AddData";
            this.btn_AddData.Size = new System.Drawing.Size(100, 65);
            this.btn_AddData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AddData.TabIndex = 46;
            this.btn_AddData.TabStop = false;
            this.btn_AddData.Click += new System.EventHandler(this.btn_AddData_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(38, 334);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(69, 25);
            this.lbl_Name.TabIndex = 45;
            this.lbl_Name.Text = "Name:";
            // 
            // skillBox
            // 
            this.skillBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.skillBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillBox.ForeColor = System.Drawing.Color.White;
            this.skillBox.Location = new System.Drawing.Point(400, 378);
            this.skillBox.Name = "skillBox";
            this.skillBox.Size = new System.Drawing.Size(123, 25);
            this.skillBox.TabIndex = 44;
            this.skillBox.Text = "";
            // 
            // lbl_Skills
            // 
            this.lbl_Skills.AutoSize = true;
            this.lbl_Skills.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Skills.ForeColor = System.Drawing.Color.White;
            this.lbl_Skills.Location = new System.Drawing.Point(332, 374);
            this.lbl_Skills.Name = "lbl_Skills";
            this.lbl_Skills.Size = new System.Drawing.Size(60, 25);
            this.lbl_Skills.TabIndex = 43;
            this.lbl_Skills.Text = "Skills:";
            // 
            // genderBox
            // 
            this.genderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.ForeColor = System.Drawing.Color.White;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(400, 338);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(123, 21);
            this.genderBox.TabIndex = 42;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.White;
            this.lbl_Gender.Location = new System.Drawing.Point(312, 336);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(80, 25);
            this.lbl_Gender.TabIndex = 41;
            this.lbl_Gender.Text = "Gender:";
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageBox.ForeColor = System.Drawing.Color.White;
            this.ageBox.Location = new System.Drawing.Point(113, 378);
            this.ageBox.Multiline = true;
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(123, 24);
            this.ageBox.TabIndex = 40;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.ForeColor = System.Drawing.Color.White;
            this.lbl_Age.Location = new System.Drawing.Point(56, 374);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(51, 25);
            this.lbl_Age.TabIndex = 39;
            this.lbl_Age.Text = "Age:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.ForeColor = System.Drawing.Color.White;
            this.nameBox.Location = new System.Drawing.Point(113, 336);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(123, 24);
            this.nameBox.TabIndex = 38;
            // 
            // nameCheck
            // 
            this.nameCheck.Location = new System.Drawing.Point(242, 334);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(44, 26);
            this.nameCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameCheck.TabIndex = 47;
            this.nameCheck.TabStop = false;
            // 
            // ageCheck
            // 
            this.ageCheck.Location = new System.Drawing.Point(242, 378);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(44, 25);
            this.ageCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ageCheck.TabIndex = 48;
            this.ageCheck.TabStop = false;
            // 
            // skillsCheck
            // 
            this.skillsCheck.Location = new System.Drawing.Point(529, 379);
            this.skillsCheck.Name = "skillsCheck";
            this.skillsCheck.Size = new System.Drawing.Size(44, 24);
            this.skillsCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skillsCheck.TabIndex = 49;
            this.skillsCheck.TabStop = false;
            // 
            // genderCheck
            // 
            this.genderCheck.Location = new System.Drawing.Point(529, 338);
            this.genderCheck.Name = "genderCheck";
            this.genderCheck.Size = new System.Drawing.Size(44, 22);
            this.genderCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genderCheck.TabIndex = 50;
            this.genderCheck.TabStop = false;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.genderCheck);
            this.Controls.Add(this.skillsCheck);
            this.Controls.Add(this.ageCheck);
            this.Controls.Add(this.nameCheck);
            this.Controls.Add(this.btn_AddData);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.skillBox);
            this.Controls.Add(this.lbl_Skills);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dgInterviewees);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddData";
            this.Load += new System.EventHandler(this.AddData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillsCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgInterviewees;
        private System.Windows.Forms.PictureBox btn_AddData;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.RichTextBox skillBox;
        private System.Windows.Forms.Label lbl_Skills;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox nameCheck;
        private System.Windows.Forms.PictureBox ageCheck;
        private System.Windows.Forms.PictureBox skillsCheck;
        private System.Windows.Forms.PictureBox genderCheck;
    }
}