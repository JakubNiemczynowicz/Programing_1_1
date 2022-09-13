namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            long sum = 0;
            Console.WriteLine("How many numbers you want to add?");

            int numbers = int.Parse(Console.ReadLine());
            //number of random numbers


            int number;
            string result = "Calculating the sum:";
            for (int i = 0; i < numbers; i++)
            {
                number = rnd.Next(101, 10000);
               // Console.WriteLine($"number{i+1} = {number}");
                sum += number;
                result = $"{result} {number}";

                if (i != numbers-1) result = $"{result} +";


            }
            //  result = $"{result} = {sum}";

            Console.WriteLine(result);
            Console.WriteLine($"The result: {sum}");
        }
    }
}