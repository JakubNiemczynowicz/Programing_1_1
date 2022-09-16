namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtCalculateAmount_Click(object sender, EventArgs e)
        {
            const double PriceOfLiter = 1.79;
            /*Console.Write("Enter the price of 1 liter fule: ");

            string input = Console.ReadLine();
            double priceOfLiter = double.Parse(input);
            //Convert.ToDouble(input); */

     
            string input = txtNumberOfLiter.Text;
            double numberOfLiters = double.Parse(input);

            double amount = numberOfLiters * PriceOfLiter;
            lbAmountToBePaid.Text = $"{amount:0.00}";

        }
    }
}