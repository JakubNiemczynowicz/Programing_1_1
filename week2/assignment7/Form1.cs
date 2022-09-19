using System.Globalization;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            txtBoxEnd.Text = null;
            txtBoxPrice.Text = null;
            txtBoxStart.Text = null;

            lbPriceExclValue.Text = "...";
            lbPriceIncl.Text = "...";
            lbVatValue.Text = "...";
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            const double VatPercent = 0.21;


            string input = txtBoxStart.Text;
            double start = double.Parse(input);

            input = txtBoxEnd.Text;
            double end = double.Parse(input);

            double distance = end - start;

            input = txtBoxPrice.Text;
            double pricePerKm = double.Parse(input);

            double price = pricePerKm * distance;
            double vat = price * VatPercent;
            double total = vat + price;

            lbPriceExclValue.Text = $"{price:0.00}";
            lbVatValue.Text = $"{vat:0.00}";
            lbPriceIncl.Text = $"{total:0.00}";




        }

        private void ibPriceIncl_Click(object sender, EventArgs e)
        {

        }
    }
}