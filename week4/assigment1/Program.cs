using System.Globalization;

namespace assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;



            double number =1, sum=0, i = 0;
            bool breakNumber = false;



            do
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    sum += number;
                    i += 1;
                }
                breakNumber = number == 0;
            }
            while (!breakNumber);

            double average = sum / i;
            Console.WriteLine($"Average off all positive numbers is: {average:0.00}");

        }
    }
}