using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInfo
{
    public enum Options
    {
        AllInfo = 0,
        Marks = 1
    }
    public partial class Form3 : Form
    {
        public Student currentStudent;
        public Options option;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            if (option == Options.AllInfo)
            {
                label5.Visible = false; 

                textBox1.Text = currentStudent?.LastName;
                textBox2.Text = currentStudent?.FirstName;
                textBox4.Text = currentStudent?.MiddleName;
                textBox3.Text = currentStudent?.BirthDay;
                textBox5.Text = currentStudent?.AverageScore.ToString();
            }
            if (option == Options.Marks) 
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;

                textBox5.Location = new Point (textBox5.Location.X, 101);
                labelAS.Location = new Point(labelAS.Location.X, 101);
                textBox5.Text = currentStudent?.AverageScore.ToString();
            }
        }
    }
}
