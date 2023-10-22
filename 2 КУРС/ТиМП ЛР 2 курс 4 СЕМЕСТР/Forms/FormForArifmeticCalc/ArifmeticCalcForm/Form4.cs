using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsInfo
{
    public partial class Form4 : Form
    {
        public List<Student> studentsList = new List<Student>();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = studentsList.Count;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = studentsList[i].FullName; 
                dataGridView1.Rows[i].Cells[2].Value = studentsList[i].BirthDay;
                dataGridView1.Rows[i].Cells[3].Value = studentsList[i].AverageScore;
            }
        }
    }
}
