using System.Globalization;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            int targetNumber;
            Console.Write("Enter target number: ");
            targetNumber = int.Parse(Console.ReadLine());
            int number, numberCount = 0;
            bool endNumber = false;


            do
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());

                if (number == targetNumber) numberCount++;

                endNumber = number == 0;
            }
            while (!endNumber);

            Console.WriteLine($"Count of the numbers equal to target number is: {numberCount}");


        }
    }
}