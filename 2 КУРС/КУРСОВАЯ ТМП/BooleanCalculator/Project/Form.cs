using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace BooleanAlgebra
{
    public partial class Form : System.Windows.Forms.Form
    {

        private List<char> variables; 
        private List<string> operators;

        public Form()
        {
            InitializeComponent();
        }

        private void CalculateClickEventHandler(object sender, EventArgs e)
        {
            try
            {
                // Считать выражение из строки ввода
                string expression = formulaTextBox.Text;
                var variables = BooleanFunctions.GetAllVariablesFromString(expression);

                var booleanFunctions = new BooleanFunctions();

                // Получить количество переменных и создать таблицу
                int numVariables = variables.Count;
                DataTable table = new DataTable();

                for (int i = 0; i < numVariables; i++)
                {
                    table.Columns.Add(variables[i].ToString());
                }
                table.Columns.Add("Result");
                // Генерация всех возможных комбинаций значений таблицы истинности
                int numRows = (int)Math.Pow(2, numVariables);
                for (int i = 0; i < numRows; i++)
                {
                    var values = new List<int>();

                    DataRow row = table.NewRow();
                    for (int j = 0; j < numVariables; j++)
                    {
                        row[j] = Convert.ToString(i, 2).PadLeft(numVariables, '0')[j];
                    }
                    for (int j = numVariables - 1; j >= 0; j--)
                    {
                        int bit = (i >> j) & 1;
                        values.Add(bit);
                    }

                    booleanFunctions.SetVariables(variables.ToArray(), values.ToArray());
                    row["Result"] = Handler.Calculate(expression, booleanFunctions);
                    table.Rows.Add(row);
                }

                // Отображение таблицы с помощью DataGridView
                dgvTruthTable.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private int GetNumVariables(string expression)
        {
            // Получить количество всех уникальных символов в верхнем регистре
            return expression.Where(c => Char.IsUpper(c)).Distinct().Count();
        }

        private void calculateButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculateClickEventHandler(sender, e);
                e.Handled = true; 
            }
        }
    }
}