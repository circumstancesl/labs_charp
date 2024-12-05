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

        private void btnGoldenRatio_Click(object sender, EventArgs e)
        {
            goldenRatioForm goldenRatioForm = new goldenRatioForm();
            goldenRatioForm.Show();
        }

        private void btnNewton_Click(object sender, EventArgs e)
        {
            NewtonForm newtonForm = new NewtonForm();
            newtonForm.Show();
        }
    }
}
