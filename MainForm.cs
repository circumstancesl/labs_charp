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

        private void btnCoordinateDescent_Click_1(object sender, EventArgs e)
        {
            coordinateDescentForm coordinateDescentForm = new coordinateDescentForm();
            coordinateDescentForm.Show();
        }

        private void btnSortings_Click(object sender, EventArgs e)
        {
            sortingForm sortingForm = new sortingForm();
            sortingForm.Show();
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            integralForm integralForm = new integralForm();
            integralForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            matrixForm matrixForm = new matrixForm();
            matrixForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mnkForm mnkForm = new mnkForm();
            mnkForm.Show();
        }
    }
}
