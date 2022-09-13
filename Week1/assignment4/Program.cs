namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            string input;
            Console.Write("enter a number: ");
            input = Console.ReadLine();
            int number = int.Parse(input);
            int result = number + number;
            result += 10;
            result /= 2;
            result -= number;
            Console.WriteLine($"result is {result}");
        }
    }
}