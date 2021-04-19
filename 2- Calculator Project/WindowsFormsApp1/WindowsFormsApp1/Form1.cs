using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double result;
        String operationPerformed;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e){}

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
                Equal.PerformClick();
            operationPerformed = button.Text;
            result = Double.Parse(Result.Text);
            currentOperation.Text = result + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void operandClick(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isOperationPerformed)
                Result.Clear();
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!Result.Text.Contains("."))
                    Result.Text += button.Text;
            }
            else
                Result.Text += button.Text;
            isOperationPerformed = false;
        }

        private void clearEntry(object sender, EventArgs e)
        {
            Result.Text = "0";
        }
        private void clear(object sender, EventArgs e)
        {
            Result.Text = "0";
            result = 0;
            currentOperation.Text = "";
        }

        private void equal(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    Result.Text = (result + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (result - Double.Parse(Result.Text)).ToString();
                    break;
                case "×":
                    Result.Text = (result * Double.Parse(Result.Text)).ToString();
                    break;
                case "÷":
                    Result.Text = (result / Double.Parse(Result.Text)).ToString();
                    break;
            }
            result = Double.Parse(Result.Text);
            currentOperation.Text = "";
        }
    }
}
