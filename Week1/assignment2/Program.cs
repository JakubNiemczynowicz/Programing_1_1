namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine())+1;
            Console.WriteLine($"Next year you will be {age} years old.");

        }

    }
}