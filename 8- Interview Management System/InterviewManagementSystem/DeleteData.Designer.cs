namespace InterviewManagementSystem
{
    partial class DeleteData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteData));
            this.endIndexBox = new System.Windows.Forms.TextBox();
            this.initialIndexBox = new System.Windows.Forms.TextBox();
            this.dgInterviewees = new System.Windows.Forms.DataGridView();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.btn_DeleteData = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DeleteData)).BeginInit();
            this.SuspendLayout();
            // 
            // endIndexBox
            // 
            this.endIndexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.endIndexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endIndexBox.ForeColor = System.Drawing.Color.White;
            this.endIndexBox.Location = new System.Drawing.Point(416, 359);
            this.endIndexBox.Multiline = true;
            this.endIndexBox.Name = "endIndexBox";
            this.endIndexBox.Size = new System.Drawing.Size(123, 24);
            this.endIndexBox.TabIndex = 43;
            // 
            // initialIndexBox
            // 
            this.initialIndexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.initialIndexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.initialIndexBox.ForeColor = System.Drawing.Color.White;
            this.initialIndexBox.Location = new System.Drawing.Point(211, 358);
            this.initialIndexBox.Multiline = true;
            this.initialIndexBox.Name = "initialIndexBox";
            this.initialIndexBox.Size = new System.Drawing.Size(123, 24);
            this.initialIndexBox.TabIndex = 42;
            // 
            // dgInterviewees
            // 
            this.dgInterviewees.AllowUserToAddRows = false;
            this.dgInterviewees.AllowUserToDeleteRows = false;
            this.dgInterviewees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInterviewees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.Location = new System.Drawing.Point(24, 2);
            this.dgInterviewees.Name = "dgInterviewees";
            this.dgInterviewees.ReadOnly = true;
            this.dgInterviewees.Size = new System.Drawing.Size(764, 333);
            this.dgInterviewees.TabIndex = 41;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.Color.White;
            this.fromLabel.Location = new System.Drawing.Point(130, 357);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(62, 25);
            this.fromLabel.TabIndex = 46;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(362, 358);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(36, 25);
            this.toLabel.TabIndex = 47;
            this.toLabel.Text = "To:";
            // 
            // btn_DeleteData
            // 
            this.btn_DeleteData.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteData.Image")));
            this.btn_DeleteData.Location = new System.Drawing.Point(577, 343);
            this.btn_DeleteData.Name = "btn_DeleteData";
            this.btn_DeleteData.Size = new System.Drawing.Size(74, 53);
            this.btn_DeleteData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_DeleteData.TabIndex = 49;
            this.btn_DeleteData.TabStop = false;
            this.btn_DeleteData.Click += new System.EventHandler(this.btn_DeleteData_Click);
            // 
            // DeleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.btn_DeleteData);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.endIndexBox);
            this.Controls.Add(this.initialIndexBox);
            this.Controls.Add(this.dgInterviewees);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteData";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DeleteData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endIndexBox;
        private System.Windows.Forms.TextBox initialIndexBox;
        private System.Windows.Forms.DataGridView dgInterviewees;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.PictureBox btn_DeleteData;
    }
}