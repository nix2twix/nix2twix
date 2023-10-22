using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace FunctionsApplication
{
    public partial class WorkForm5 : Form
    {
        public WorkForm5()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMakeReport_Click(object sender, EventArgs e)
        {
            double totalSum = 0;
            string filePath = @"C:\Users\Вика\Documents\Orders.xlsx"; 
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(filePath);
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.get_Range("A1", "E6");

            var table = new System.Data.DataTable();

            for (int i = 1; i <= range.Columns.Count; i++)
            {
                table.Columns.Add(range.Cells[1, i].Value.ToString());
            }

            for (int i = 2; i <= range.Rows.Count; i++)
            {
                DataRow row = table.Rows.Add();
                for (int j = 1; j <= range.Columns.Count; j++)
                {
                    row[j - 1] = range.Cells[i, j].Value.ToString();

                    if (j == 5)
                    {
                        totalSum += Convert.ToDouble(range.Cells[i, j].Value);
                    }
                }
            }

            dataGridViewOrders.DataSource = table;

            textBoxTotalSum.Text = totalSum.ToString();
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
        }
    }
}
