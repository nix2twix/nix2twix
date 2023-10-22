using Microsoft.Office.Interop.Excel;
using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace FunctionsApplication
{
    public partial class WorkForm7 : Form
    {
        public WorkForm7()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var array = ReadArray();
            SortingArray(ref array);
            int max = array[array.Length - 1];
            textBoxArray.Text = string.Join(" ", array); // Вывод отсортированного массива
            textBoxMax.Text = max.ToString();
        }
        static void SortingArray(ref int[] arr)
        {
            Array.Sort(arr);
        }
        private int[] ReadArray()
        {
            string[] input = textBoxArray.Text.Split(' ');

            int[] array = new int[input.Length]; 

            for (int i = 0; i < input.Length; i++)
            {
                 array[i] = int.Parse(input[i]); 
            }

            return array;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
