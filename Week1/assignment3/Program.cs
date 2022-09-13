namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();


            Console.WriteLine($"Your full name is {firstName} {lastName}");
            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);
           // Console.WriteLine("Your full name is " + firstName + " " + lastName);

            Console.ReadKey();

        }
    }
}