using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;


namespace StudentsInfo
{
    public partial class Form2 : Form
    {
        public List<Student> listOfStudents;
        public Form2()
        {
            listOfStudents = new List<Student>(){
                new Student("Булочкин", "Игорь", "Михайлович", "17.01.1999", 3.4f),
                new Student("Котиков", "Михаил", "Юрьевич", "19.08.1997", 4.9f),
                new Student("Бублик", "Александр", "Сергеевич", "30.09.2003", 4.3f),
                new Student("Яблочков", "Валерий", "Ярославович", "03.03.2003", 5f),
                new Student("Кексик", "Вероника", "Сергеевна", "12.05.2003", 4.8f),
            };
            InitializeComponent();
        }
        private void outputInExel(object sender, EventArgs e)
        {
            if (listOfStudents.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                ExcelApp.Cells[1, 1] = "№п/п";
                ExcelApp.Cells[1, 2] = "ФИО";
                ExcelApp.Cells[1, 3] = "Дата рождения";
                ExcelApp.Cells[1, 4] = "Средний балл";

                for (int i = 2; i < listOfStudents.Count + 2; i++)
                {
                    ExcelApp.Cells[i, 1] = i-1 + ".\t";
                }
                for (int i = 0; i < listOfStudents.Count; i++)
                {
                    ExcelApp.Cells[i+2, 2] = listOfStudents[i].FullName;
                    ExcelApp.Cells[i+2, 3] = listOfStudents[i].BirthDay;
                    ExcelApp.Cells[i+2, 4] = listOfStudents[i].AverageScore;
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
        }

        private void showStudentInfoOnClick(object sender, EventArgs e)
        {
            if (studentBox.SelectedIndex != -1)
            {
                Form3 frm3 = new Form3();
                if (optionBox.SelectedIndex == 0)
                {
                    frm3.option = Options.AllInfo;
                }
                else
                {
                    frm3.option = Options.Marks;
                }
                frm3.currentStudent = listOfStudents[studentBox.SelectedIndex];
                frm3.Show();
            }
        }

        private void showAllStudentsOnClick(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.studentsList = listOfStudents;
            this.Hide();
            frm4.Show();
        }
    }
}
