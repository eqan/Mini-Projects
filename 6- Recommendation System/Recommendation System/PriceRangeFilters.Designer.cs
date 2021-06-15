namespace Recommendation_System
{
    partial class PriceRangeFilters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceRangeFilters));
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.powerBtn = new System.Windows.Forms.PictureBox();
            this.locationBtn = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(124, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 348);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(46)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.powerBtn);
            this.panel1.Controls.Add(this.locationBtn);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 36);
            this.panel2.TabIndex = 3;
            // 
            // powerBtn
            // 
            this.powerBtn.Location = new System.Drawing.Point(12, 274);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(37, 36);
            this.powerBtn.TabIndex = 3;
            this.powerBtn.TabStop = false;
            this.powerBtn.Click += new System.EventHandler(this.powerBtn_Click);
            // 
            // locationBtn
            // 
            this.locationBtn.Location = new System.Drawing.Point(12, 222);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(37, 36);
            this.locationBtn.TabIndex = 2;
            this.locationBtn.TabStop = false;
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 167);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(37, 36);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.TabStop = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(12, 111);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(37, 36);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("XXII DONT-MESS-WITH-VIKINGS", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select A Marquee";
            // 
            // PriceRangeFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PriceRangeFilters";
            this.Text = "Marquee Recommendation System";
            this.Load += new System.EventHandler(this.PriceRangeFilters_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.powerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox powerBtn;
        private System.Windows.Forms.PictureBox locationBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}