namespace InterviewManagementSystem
{
    partial class SearchData
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dgInterviewees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(12, 22);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(708, 31);
            this.searchBox.TabIndex = 44;
            this.searchBox.Text = "Search";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dgInterviewees
            // 
            this.dgInterviewees.AllowUserToAddRows = false;
            this.dgInterviewees.AllowUserToDeleteRows = false;
            this.dgInterviewees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInterviewees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dgInterviewees.Location = new System.Drawing.Point(12, 68);
            this.dgInterviewees.Name = "dgInterviewees";
            this.dgInterviewees.ReadOnly = true;
            this.dgInterviewees.Size = new System.Drawing.Size(708, 331);
            this.dgInterviewees.TabIndex = 43;
            // 
            // SearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dgInterviewees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInterviewees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dgInterviewees;
    }
}

