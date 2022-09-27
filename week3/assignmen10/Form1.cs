using System.Globalization;

namespace assignmen10
{
    public partial class Form1 : Form
    {

        const double BasePrice = 12;


        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            double price = BasePrice;

            int age = int.Parse(txtBoxAge.Text);
            if (age < 5)
            {
                price = 0;
            }
            else if (age <= 12)
            {
                price /= 2;
            }
            else if (age >= 55)
            {
                price = 0;
            }

            lbPriceValue.Text = $"€{price:0.00}";

        }
    }
}