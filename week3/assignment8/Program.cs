namespace assignment8
{
    internal class Program
    {
        const int WorkTimeLimit = 10000;
        const int YersLimit = 7;
        const int FailuresLimit = 25;

        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int workTime = int.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter number of failures: ");
            int failures = int.Parse(Console.ReadLine());

            string output;

            Console.WriteLine("");

            if (workTime > WorkTimeLimit || years >= YersLimit || failures > FailuresLimit)
            {
                output = "Machine needs to be replaced.";
            }
            else
            {
                output = "Machine does not need to be replaced.";

            }
            Console.WriteLine(output);

        }
    }
}