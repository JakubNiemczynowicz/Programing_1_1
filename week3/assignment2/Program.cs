namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4): ");
            int number = int.Parse(Console.ReadLine());
            string output;
            switch (number)
            {
                case 1:
                    output = "clubs";
                    break;
                case 2:
                    output = "diamonds";
                    break;
                case 3:
                    output = "hearts";
                    break;
                case 4:
                    output = "spades";
                    break;
                default:
                    output = "Incorect number!";
                    break;
            }
            Console.WriteLine(output);



        }
    }
}