using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormTMP
{
    public partial class FormTMP2 : Form
    {
        public FormTMP2() => InitializeComponent();

        private void buttonBackToForm1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != typeof(FormTMP))
                    form.Close();
            }
        }

        private void buttonShowHiddenOnClick(object sender, EventArgs e)
        {
            if (!labelTSU.Visible)
            {
                labelTSU.Visible = true;
                labelProfs.Visible = true;
                textBoxIn.Visible = true;
                textBoxOut.Visible= true;
                labelYearGradFrom.Visible = true;
                labelYearIn.Visible = true; 
                buttonCalculateGradYear.Visible = true;
                buttonYearIn.Visible = true;
                buttonClear.Visible = true; 
            }
            else
            {
                labelTSU.Visible = false;
                labelProfs.Visible = false;
                textBoxIn.Visible = false;
                textBoxOut.Visible = false;
                labelYearGradFrom.Visible = false;
                labelYearIn.Visible = false;
                buttonCalculateGradYear.Visible = false;
                buttonClear.Visible = false;
                buttonYearIn.Visible = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) => Application.Exit();

        private void buttonCalcYear_Click(object sender, EventArgs e)
        {
            if (textBoxIn.Text != string.Empty)
            {
                textBoxOut.Text = (int.Parse(textBoxIn.Text) + 5).ToString();
            }
        }

        private void buttonClearYear_Click(object sender, EventArgs e)
        {
            textBoxIn.Text = string.Empty;
            textBoxOut.Text = string.Empty;
        }

        private void textBoxIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOut_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
        }
    }
}
