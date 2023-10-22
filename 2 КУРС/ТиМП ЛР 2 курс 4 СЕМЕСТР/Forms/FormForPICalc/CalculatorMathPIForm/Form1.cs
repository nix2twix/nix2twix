using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMathPIForm
{
    public partial class MathPI : Form
    {
        public MathPI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRegularPI.Text = Math.Round(Math.PI, 6).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDoublePI.Text = Math.Round(Math.PI, 12).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxRoundPI.Text = Math.Round(Math.PI, 5).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
