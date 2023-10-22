namespace FormTMP
{
    public partial class FormTMP : Form
    {
        public FormTMP()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 2)
            {
                FormTMP2 form = new FormTMP2();
                form.ShowDialog();
            }
        }

    }
}