using System.Globalization;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbPriceValue_Click(object sender, EventArgs e)
        {

        }

        private void btCalculate_Click(object sender, EventArgs e)
        {


            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            const double VatPercent = 0.21;



            string input = txtBoxTshirtNo.Text;
            double tshirtNo = double.Parse(input);
            input = txtBoxJeansNo.Text;
            double jeansNo = double.Parse(input);

            double price = tshirtNo * 30 + jeansNo * 100;
            double vat = VatPercent * price;
            double total = vat + price;


            DateTime date = DateTime.Now;
            string dataStr = date.ToString();

            lbPriceValue.Text = $"€ {price:0.00}";
            lbVatValue.Text = $"€ {vat:0.00}";
            lbTotalValue.Text = $"€ {total:0.00}";
            lbDateValue.Text = dataStr;



        }

        private void grBoxInvoice_Enter(object sender, EventArgs e)
        {

        }
    }
}