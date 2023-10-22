using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form

    {
        Calculator calculator = new Calculator();
        public Form()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButtonOnClick(object sender, EventArgs e)
        {
            textBar.Text += " + ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equalButtonClick(object sender, EventArgs e)
        {
            string s = textBar.Text;
            string[] separator = { " " };
            string[] textLine = s.Split(separator, StringSplitOptions.None);
            int i = 0;
            string res = string.Empty;
            foreach (var item in textLine)
            {
                switch(item)
                {
                    case "/":
                        {
                            res = (double.Parse(textLine[i - 1]) / double.Parse(textLine[i + 1])).ToString();
                            break;
                        }
                    case "*":
                        {
                            res = (double.Parse(textLine[i - 1]) * double.Parse(textLine[i + 1])).ToString();
                            break;
                        }
                    case "^":
                        {
                            res = (Math.Pow(double.Parse(textLine[i - 1]), double.Parse(textLine[i + 1]))).ToString();
                            break;
                        }
                    case "+":
                        {
                            res += (double.Parse(textLine[i - 1]) + double.Parse(textLine[i + 1])).ToString();
                            break;
                        }
                    case "-":
                        {
                            res = (double.Parse(textLine[i - 1]) - double.Parse(textLine[i + 1])).ToString();
                            break;
                        }
                }
                i++;
            }
            textBar.Text = res;

        }

        private void multipleButton_Click(object sender, EventArgs e)
        {
            textBar.Text += " * ";
        }

        private void clearButtonOnClick(object sender, EventArgs e)
        {
            textBar.Clear();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            textBar.Text += " - ";
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            textBar.Text += " / ";
        }

        private void powButton_Click(object sender, EventArgs e)
        {
            textBar.Text += " ^ ";
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            textBar.Text = Math.Sqrt(double.Parse(textBar.Text)).ToString();
        }

        void textBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                equalButtonClick(equalButton, null);
            }
        }
    }
}
