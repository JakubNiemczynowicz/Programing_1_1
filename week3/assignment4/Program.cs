using System.Globalization;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            double highest;
            double lowest;

            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber + thirdNumber;
            double average = sum / 3;
            double product = firstNumber * secondNumber * thirdNumber;

            if (firstNumber > secondNumber)
            {
                lowest = secondNumber;
                highest = firstNumber;
            }
            else
            {
                lowest = firstNumber;
                highest = secondNumber;
            }
            if (highest < thirdNumber) highest = thirdNumber;
            else if (lowest > thirdNumber) lowest = thirdNumber;

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {average:0.00}");
            Console.WriteLine($"product = {product}");
            Console.WriteLine($"highest = {highest}");
            Console.WriteLine($"lowest = {lowest}");


        }
    }
}