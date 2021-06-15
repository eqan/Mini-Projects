namespace Recommendation_System
{
    partial class MenuSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSystem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peopleEntryBox = new System.Windows.Forms.TextBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.numberOfPeopleLabel = new System.Windows.Forms.Label();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.totalBillBox = new System.Windows.Forms.TextBox();
            this.promoCodeLabel = new System.Windows.Forms.Label();
            this.promoCodeBox = new System.Windows.Forms.TextBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.powerBtn = new System.Windows.Forms.PictureBox();
            this.locationBtn = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(231, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // peopleEntryBox
            // 
            this.peopleEntryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.peopleEntryBox.ForeColor = System.Drawing.Color.White;
            this.peopleEntryBox.Location = new System.Drawing.Point(162, 333);
            this.peopleEntryBox.Name = "peopleEntryBox";
            this.peopleEntryBox.Size = new System.Drawing.Size(66, 20);
            this.peopleEntryBox.TabIndex = 1;
            this.peopleEntryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peopleEntryBox_KeyPress);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.25F);
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(270, 292);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(37, 14);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Menu";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.25F);
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(473, 293);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(32, 14);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.25F);
            this.billLabel.ForeColor = System.Drawing.Color.White;
            this.billLabel.Location = new System.Drawing.Point(656, 295);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(23, 14);
            this.billLabel.TabIndex = 4;
            this.billLabel.Text = "Bill";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(635, 326);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(66, 35);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.nextClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(257, 326);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 34);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.backClick);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(458, 325);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(66, 35);
            this.select.TabIndex = 7;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.selectClick);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(564, 389);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(66, 35);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculateClick);
            // 
            // numberOfPeopleLabel
            // 
            this.numberOfPeopleLabel.AutoSize = true;
            this.numberOfPeopleLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPeopleLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfPeopleLabel.Location = new System.Drawing.Point(84, 336);
            this.numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            this.numberOfPeopleLabel.Size = new System.Drawing.Size(72, 14);
            this.numberOfPeopleLabel.TabIndex = 9;
            this.numberOfPeopleLabel.Text = "Enter People:";
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.25F);
            this.totalBillLabel.ForeColor = System.Drawing.Color.White;
            this.totalBillLabel.Location = new System.Drawing.Point(659, 404);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(53, 14);
            this.totalBillLabel.TabIndex = 10;
            this.totalBillLabel.Text = "Total Bill:";
            // 
            // totalBillBox
            // 
            this.totalBillBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.totalBillBox.ForeColor = System.Drawing.Color.White;
            this.totalBillBox.Location = new System.Drawing.Point(712, 401);
            this.totalBillBox.Name = "totalBillBox";
            this.totalBillBox.ReadOnly = true;
            this.totalBillBox.Size = new System.Drawing.Size(66, 20);
            this.totalBillBox.TabIndex = 11;
            // 
            // promoCodeLabel
            // 
            this.promoCodeLabel.AutoSize = true;
            this.promoCodeLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.25F);
            this.promoCodeLabel.ForeColor = System.Drawing.Color.White;
            this.promoCodeLabel.Location = new System.Drawing.Point(89, 400);
            this.promoCodeLabel.Name = "promoCodeLabel";
            this.promoCodeLabel.Size = new System.Drawing.Size(70, 14);
            this.promoCodeLabel.TabIndex = 12;
            this.promoCodeLabel.Text = "Promo Code:";
            // 
            // promoCodeBox
            // 
            this.promoCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.promoCodeBox.ForeColor = System.Drawing.Color.White;
            this.promoCodeBox.Location = new System.Drawing.Point(162, 399);
            this.promoCodeBox.Name = "promoCodeBox";
            this.promoCodeBox.Size = new System.Drawing.Size(66, 20);
            this.promoCodeBox.TabIndex = 13;
            this.promoCodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("CarnacW03-ExtraBold", 8.25F);
            this.ingredientsLabel.ForeColor = System.Drawing.Color.White;
            this.ingredientsLabel.Location = new System.Drawing.Point(258, 306);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(65, 14);
            this.ingredientsLabel.TabIndex = 14;
            this.ingredientsLabel.Text = "Ingredients";
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
            this.panel1.TabIndex = 15;
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
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 65);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Items";
            // 
            // MenuSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.promoCodeBox);
            this.Controls.Add(this.promoCodeLabel);
            this.Controls.Add(this.totalBillBox);
            this.Controls.Add(this.totalBillLabel);
            this.Controls.Add(this.numberOfPeopleLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.select);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.peopleEntryBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuSystem";
            this.Text = "Marquee Recommendation System";
            this.Load += new System.EventHandler(this.MenuSystem_Load);
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
        private System.Windows.Forms.TextBox peopleEntryBox;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label numberOfPeopleLabel;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.TextBox totalBillBox;
        private System.Windows.Forms.Label promoCodeLabel;
        private System.Windows.Forms.TextBox promoCodeBox;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox powerBtn;
        private System.Windows.Forms.PictureBox locationBtn;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Label label1;
    }
}