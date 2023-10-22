using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace FunctionsApplication
{
    public partial class WorkForm2 : Form
    {
        public WorkForm2()
        {
            InitializeComponent();
        }

        private void buttonLoadFromExel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Вика\Documents\WorkList.xlsx");
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets["Лист1"];

            double a13Value = xlWorksheet.Range["A13"].Value;
            double b17Value = xlWorksheet.Range["B17"].Value;

            textBoxA.Text = a13Value.ToString();
            textBoxB.Text = b17Value.ToString();

            xlWorksheet.Range["C22"].Value = (a13Value + b17Value)*3;

            textBoxResult.Text = ((a13Value + b17Value) * 3).ToString();

            Excel.Workbook newWorkbook = xlApp.Workbooks.Add();
            Excel.Worksheet newWorksheet = newWorkbook.Sheets[1];

            newWorksheet.Range["A13"].Value = a13Value;
            newWorksheet.Range["B17"].Value = b17Value;
            newWorksheet.Range["C22"].Value = (a13Value + b17Value) * 3;

            string filename = @"C:\Users\Вика\Documents\WorkList.xlsx" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
            newWorkbook.SaveAs(filename);

            newWorkbook.Close();
            xlWorkbook.Close();
            xlApp.Quit();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
