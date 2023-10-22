using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;

namespace FunctionsApplication
{
    public partial class WorkForm4 : Form
    {
        public WorkForm4()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoadFromTxt_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader(@"C:\Users\Вика\Documents\input.txt");

            string line = reader.ReadLine();
            string[] nums = line.Split();
            int X = int.Parse(nums[0]);
            int Y = int.Parse(nums[1]);

            line = reader.ReadLine();
            int Z = int.Parse(line);

            if (textBoxPath.Text != string.Empty)
            {
                StreamWriter writer = new StreamWriter(textBoxPath.Text);
                writer.WriteLine((X + Y + Z) * 3);
                textBoxResult.Text = ((X + Y + Z) * 3).ToString();
                writer.Close();
            }
                reader.Close();
        }
    }
}
