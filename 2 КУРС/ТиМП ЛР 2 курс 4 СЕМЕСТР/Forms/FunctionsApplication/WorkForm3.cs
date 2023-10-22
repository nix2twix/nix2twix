using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;

namespace FunctionsApplication
{
    public partial class WorkForm3 : Form
    {
        public WorkForm3()
        {
            InitializeComponent();
        }

        private void buttonLoadFromExel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Вика\Documents\WorkList2.xlsx");
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets["Лист1"];

            double X = xlWorksheet.Range["B3"].Value;
            double Y = X;

            textBoxA.Text = X.ToString();

            textBoxResult.Text = (X * X + 3 * Y + 15).ToString();

            Excel.Workbook newWorkbook = xlApp.Workbooks.Add();
            Excel.Worksheet newWorksheet = newWorkbook.Sheets[1];

            newWorksheet.Range["B3"].Value = X;
            newWorksheet.Range["B4"].Value = X * X + 3 * Y + 15;

            string fileExelName = @"C:\Users\Вика\Documents\WorkList2.xlsx" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            newWorkbook.SaveAs(fileExelName);

            newWorkbook.Close();
            xlWorkbook.Close();
            xlApp.Quit();

            string fileTXTName = @"C:\Users\Вика\Documents\output.txt";
            using (StreamWriter sw = File.CreateText(fileTXTName))
            {
                sw.WriteLine("Результат: " + (X * X + 3 * Y + 15).ToString());
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
