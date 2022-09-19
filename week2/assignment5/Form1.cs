using System.Globalization;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbAverageValue_Click(object sender, EventArgs e)
        {

        }

        private void CalculateAvereage_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            string input = txtBoxNb1.Text;
            double number1 = Convert.ToDouble(input);

            input = txtBoxNb2.Text;
            double number2 = Convert.ToDouble(input);

            input = txtBoxNb3.Text;
            double number3 = Convert.ToDouble(input);

            double average = (number1 + number2 + number3) / 3;

            lbAverageValue.Text = $"{average:0.000}";





        }
    }
}