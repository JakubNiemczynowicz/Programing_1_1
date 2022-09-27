namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int highestNumber;
            int lowestNumber;

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                highestNumber = firstNumber;
                lowestNumber = secondNumber;
            }
            else
            {
                lowestNumber = firstNumber;
                highestNumber = secondNumber;
            }
            Console.WriteLine("");
            Console.WriteLine($"highest value is: {highestNumber}");
            Console.WriteLine($"lowest value is: {lowestNumber}");


        }
    }
}