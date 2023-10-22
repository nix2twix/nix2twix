using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionsApplication
{
    public partial class WorkForm1 : Form
    {
        public WorkForm1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text.Length > 0
                && textBoxB.Text.Length > 0
                && textBoxC.Text.Length > 0)
            {
                int A = int.Parse(textBoxA.Text);
                int B = int.Parse(textBoxB.Text);
                int C = int.Parse(textBoxC.Text);

                textBoxResult.Text = ((A + B + C) * 2).ToString();
            }
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) 
            {
                e.Handled = true;
            }
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
