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

        private void ButtonClick(object sender, EventArgs e)
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
            Output.Text = "0";
            currentCalculaton = "";
        }

        private void Button_ClearEntry_Click(object sender, EventArgs e)
        {
            if(currentCalculaton.Length > 0)
            {
                currentCalculaton = currentCalculaton.Remove(currentCalculaton.Length-1,1);
            }
            Output.Text = currentCalculaton;
        }
    }
}
