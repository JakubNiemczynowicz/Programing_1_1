using System.Transactions;

namespace consoleDemoTeory
{
    internal class Program
    {
        static void Main(string[] args)
        {   

           // const double PriceOfLiter = 1.79;
            Console.Write("Enter the price of 1 liter fule: ");

            string input = Console.ReadLine();
            double priceOfLiter = double.Parse(input);
            //Convert.ToDouble(input); 

            Console.Write("Enter the number of liters tanked ");
            input = Console.ReadLine();
            double numberOfLiters = double.Parse(input);

            double amount = numberOfLiters * priceOfLiter;
            Console.WriteLine($"You have to pay: {amount:0.00}");

        }
    }
}