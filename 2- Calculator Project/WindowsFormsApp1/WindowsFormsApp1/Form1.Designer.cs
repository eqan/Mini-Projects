namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Number7 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.DotCharacter = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.currentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Number7
            // 
            this.Number7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number7.Location = new System.Drawing.Point(12, 73);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(37, 23);
            this.Number7.TabIndex = 0;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.operandClick);
            // 
            // Number8
            // 
            this.Number8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number8.Location = new System.Drawing.Point(55, 73);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(37, 23);
            this.Number8.TabIndex = 0;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.operandClick);
            // 
            // Number9
            // 
            this.Number9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number9.Location = new System.Drawing.Point(98, 73);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(37, 23);
            this.Number9.TabIndex = 0;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.operandClick);
            // 
            // ClearEntry
            // 
            this.ClearEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearEntry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearEntry.Location = new System.Drawing.Point(184, 73);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(37, 23);
            this.ClearEntry.TabIndex = 0;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.clearEntry);
            // 
            // Division
            // 
            this.Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Division.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Division.Location = new System.Drawing.Point(141, 73);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(37, 23);
            this.Division.TabIndex = 0;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.operatorClick);
            // 
            // Multiplication
            // 
            this.Multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Multiplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multiplication.Location = new System.Drawing.Point(141, 102);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(37, 23);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "×";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.operatorClick);
            // 
            // Clear
            // 
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(184, 102);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(37, 23);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.clear);
            // 
            // Number6
            // 
            this.Number6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number6.Location = new System.Drawing.Point(98, 102);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(37, 23);
            this.Number6.TabIndex = 0;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.operandClick);
            // 
            // Number5
            // 
            this.Number5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number5.Location = new System.Drawing.Point(55, 102);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(37, 23);
            this.Number5.TabIndex = 0;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.operandClick);
            // 
            // Number4
            // 
            this.Number4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number4.Location = new System.Drawing.Point(12, 102);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(37, 23);
            this.Number4.TabIndex = 0;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.operandClick);
            // 
            // Subtraction
            // 
            this.Subtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Subtraction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Subtraction.Location = new System.Drawing.Point(141, 131);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(37, 23);
            this.Subtraction.TabIndex = 0;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.operatorClick);
            // 
            // Number3
            // 
            this.Number3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number3.Location = new System.Drawing.Point(98, 131);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(37, 23);
            this.Number3.TabIndex = 0;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.operandClick);
            // 
            // Number2
            // 
            this.Number2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number2.Location = new System.Drawing.Point(55, 131);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(37, 23);
            this.Number2.TabIndex = 0;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.operandClick);
            // 
            // Number1
            // 
            this.Number1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number1.Location = new System.Drawing.Point(12, 131);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(37, 23);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.operandClick);
            // 
            // Add
            // 
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(141, 160);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(37, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.operatorClick);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.Control;
            this.Equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equal.Location = new System.Drawing.Point(184, 131);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(37, 52);
            this.Equal.TabIndex = 0;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.equal);
            // 
            // DotCharacter
            // 
            this.DotCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DotCharacter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DotCharacter.Location = new System.Drawing.Point(98, 160);
            this.DotCharacter.Name = "DotCharacter";
            this.DotCharacter.Size = new System.Drawing.Size(37, 23);
            this.DotCharacter.TabIndex = 0;
            this.DotCharacter.Text = ".";
            this.DotCharacter.UseVisualStyleBackColor = true;
            this.DotCharacter.Click += new System.EventHandler(this.operandClick);
            // 
            // Number0
            // 
            this.Number0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Number0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Number0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number0.Location = new System.Drawing.Point(13, 160);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(80, 23);
            this.Number0.TabIndex = 0;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.operandClick);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(14, 33);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(207, 23);
            this.Result.TabIndex = 1;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentOperation
            // 
            this.currentOperation.AutoSize = true;
            this.currentOperation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentOperation.ForeColor = System.Drawing.Color.Gray;
            this.currentOperation.Location = new System.Drawing.Point(14, 15);
            this.currentOperation.Name = "currentOperation";
            this.currentOperation.Size = new System.Drawing.Size(0, 15);
            this.currentOperation.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 207);
            this.Controls.Add(this.currentOperation);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.DotCharacter);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.ClearEntry);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button DotCharacter;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label currentOperation;
    }
}

