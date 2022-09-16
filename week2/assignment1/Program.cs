using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            const double VatPercent = 0.21;
            Console.Write("Enter the price: ");
            string input = Console.ReadLine();
            double price = double.Parse(input);
            double vat = price * VatPercent;
            double total = vat + price;
            Console.WriteLine($"price {price:0.00}, VAT: {vat:0.00}, total: {total:0.00}");



        }
    }
}