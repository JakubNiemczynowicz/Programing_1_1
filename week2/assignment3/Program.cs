using System.Globalization;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter the number of seconds: ");
            string input = Console.ReadLine();
            int seconds = int.Parse(input);
            int hours = seconds / 3600;
            seconds %= 3600;
            int minutes = seconds / 60;
            seconds %= 60;

            Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");




        }
    }
}