using System.Globalization;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            int number,sum=0;
            bool endNumber;
            int counter = 1;

            do
            {
                Console.Write("Enter a number: ");
                
                    
                   number = int.Parse(Console.ReadLine());

                if (counter == 5)
                {
                    sum += number;
                    counter = 0;
                }
                    counter++;
                endNumber = number == 0;
            }
            while (!endNumber);


            Console.WriteLine($"Sum of 5th, 10th, 15th, ... number is: {sum}");

        }
    }
}