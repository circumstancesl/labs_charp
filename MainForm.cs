namespace dichotomy_method
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDichotomy_Click(object sender, EventArgs e)
        {
            dichotomyForm dichotomyForm = new dichotomyForm();
            dichotomyForm.Show();
        }
    }
}
