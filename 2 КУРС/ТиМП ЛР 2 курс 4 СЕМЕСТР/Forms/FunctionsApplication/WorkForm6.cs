using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;

namespace FunctionsApplication
{
    public partial class WorkForm6 : Form
    {
        public WorkForm6()
        {
            InitializeComponent();
        }

        private void buttonCheckStudent_Click(object sender, EventArgs e)
        { 
            if (textBoxSurname.Text == "Иванов" 
                || textBoxSurname.Text == "Иванова")
            {
                MessageBox.Show("Здравствуйте! Вы не закрыли сессию :(");
            }
            else
            {
                MessageBox.Show($"Здравствуйте, {textBoxFirstName.Text} {textBoxSurname.Text}! " + 
                    "Поздравляем с окончанием летней сессии!");
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
