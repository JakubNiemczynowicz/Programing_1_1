namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, age;
            Console.Write("Entart your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Console.ReadLine();


            Console.WriteLine($"Your name is {name}");
            Console.WriteLine($"Your age is {age}");

        }
    }
}