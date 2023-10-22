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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTask7_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm7();
            workForm.ShowDialog();
        }

        private void buttonTask6_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm6();
            workForm.ShowDialog();
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm5();
            workForm.ShowDialog();
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm4();
            workForm.ShowDialog();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm3();
            workForm.ShowDialog();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm2();
            workForm.ShowDialog();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            var workForm = new WorkForm1();
            workForm.ShowDialog();
        }
    }
}
