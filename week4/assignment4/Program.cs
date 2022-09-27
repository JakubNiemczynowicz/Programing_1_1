namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 20;
            int number1 = 1, number2 = 1;
            int carry;

      
            for (int i = 0; i < count; i++)
            {
                Console.Write(number1);
                carry = number2;
                number2 = number2 + number1;
                number1 = carry;
                if (i != count - 1)
                    Console.Write(", ");
            }



        }
    }
}