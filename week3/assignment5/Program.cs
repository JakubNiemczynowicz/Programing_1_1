namespace assignment5
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int higher;
            int lower;

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0)
            {
                if (firstNumber > secondNumber)
                {
                    higher = 1;
                    lower = 2;
                }
                else
                {

                    lower = 1;
                    higher = 2;
                }


                Console.WriteLine($"Number {higher} is multiple of number {lower}");

            }
            else
                Console.WriteLine("Numbers are not multiples");





        }
    }
}