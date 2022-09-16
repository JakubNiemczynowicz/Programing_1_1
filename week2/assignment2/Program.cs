using System.Globalization;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter 1st number: ");
            string input = Console.ReadLine();
            double number1 = Convert.ToDouble(input);

            Console.Write("Enter 2nd number: ");
            input = Console.ReadLine();
            double number2 = Convert.ToDouble(input);

            Console.Write("Enter 3rd number: ");
            input = Console.ReadLine();
            double number3 = Convert.ToDouble(input);

            double average = (number1 + number2 + number3) / 3;

            Console.WriteLine($"The average is: {average}");






        }
    }
}