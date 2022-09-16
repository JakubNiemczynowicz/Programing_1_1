using System.Globalization;

namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbVat_Click(object sender, EventArgs e)
        {

        }

        private void btDetermineVat_Click(object sender, EventArgs e)
        {

            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            const double VatPercent = 0.21;
       
            string input =  txtBoxPrice.Text;
            double price = double.Parse(input);
            double vat = price * VatPercent;
            double total = vat + price;
            lbPriceOut =  price:0.00;
            lbVatOut =    vat:0.00;
            lbTotalOut  = total:0.00;





        }
    }
}