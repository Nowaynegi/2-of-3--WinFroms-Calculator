using System.Data;

namespace WinForms_Calculator
{
    public partial class Form1 : Form
    {
        private string currentCalculaton = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonCLick(object sender, EventArgs e)
        {
            currentCalculaton += (sender as Button).Text;
            Output.Text = currentCalculaton;
        }

        private void ButtonEqualsClick(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculaton.ToString();
            try
            {
                Output.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculaton = Output.Text;
            }
            catch (Exception ex)
            {
                Output.Text = "what the heckies!";
                currentCalculaton = "";
            }
        }
        private void ButtonClearClick(object sender, EventArgs e)
        {

        }
    }
}
