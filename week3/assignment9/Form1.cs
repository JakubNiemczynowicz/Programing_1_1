using System.CodeDom;
using System.Globalization;

namespace assignment9
{
    public partial class Form1 : Form
    {
        const double HandballFee = 225;
        const double FootballFee = 175;
        const double DiscountAgeYears = 40;
        const double DiscountAgeValue = 25;
        const double DiscountMembershipYears = 10;
        const double DiscountMembershipValue = 20;


        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            double fee=0;


            if (RadioBtFootball.Checked)
            {
                fee = FootballFee;
            }
            else if (RadioBtHandball.Checked)
            {
                fee = HandballFee;
            }

            int age = int.Parse(txtBoxAge.Text);
            int membership = int.Parse(txtBoxMembership.Text);

            if (age > DiscountAgeYears) fee -= DiscountAgeValue;
            if (membership >DiscountMembershipYears) fee -= DiscountMembershipValue;


            lbFee.Text = $"€ {fee:0.00}";
        
        }
    }
}