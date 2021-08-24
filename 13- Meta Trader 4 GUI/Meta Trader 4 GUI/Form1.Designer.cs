namespace Meta_Trader_4_GUI
{
    partial class MetaTraderBotInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetaTraderBotInstaller));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.metaTraderVersionList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Copt_Files_ButtonClick);
            // 
            // metaTraderVersionList
            // 
            this.metaTraderVersionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metaTraderVersionList.FormattingEnabled = true;
            this.metaTraderVersionList.Location = new System.Drawing.Point(65, 40);
            this.metaTraderVersionList.MaxDropDownItems = 100;
            this.metaTraderVersionList.Name = "metaTraderVersionList";
            this.metaTraderVersionList.Size = new System.Drawing.Size(329, 21);
            this.metaTraderVersionList.TabIndex = 3;
            // 
            // MetaTraderBotInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 100);
            this.Controls.Add(this.metaTraderVersionList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetaTraderBotInstaller";
            this.Text = "Meta Trader 4 Bot Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox metaTraderVersionList;
    }
}

