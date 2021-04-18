namespace Recommendation_System
{
    partial class CompleteMarqueeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteMarqueeDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.cuisines = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.powerBtn = new System.Windows.Forms.PictureBox();
            this.locationBtn = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(310, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(403, 283);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Name";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.ForeColor = System.Drawing.Color.White;
            this.destination.Location = new System.Drawing.Point(380, 324);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(126, 27);
            this.destination.TabIndex = 2;
            this.destination.Text = "Destination";
            this.destination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuisines
            // 
            this.cuisines.AutoSize = true;
            this.cuisines.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuisines.ForeColor = System.Drawing.Color.White;
            this.cuisines.Location = new System.Drawing.Point(263, 362);
            this.cuisines.Name = "cuisines";
            this.cuisines.Size = new System.Drawing.Size(98, 21);
            this.cuisines.TabIndex = 3;
            this.cuisines.Text = "Decorations";
            this.cuisines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 168);
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
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(12, 111);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(37, 36);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // CompleteMarqueeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cuisines);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompleteMarqueeDetails";
            this.Text = "Marquee Recommendation System";
            this.Load += new System.EventHandler(this.CompleteMarqueeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.powerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label cuisines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox powerBtn;
        private System.Windows.Forms.PictureBox locationBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox homeBtn;
    }
}