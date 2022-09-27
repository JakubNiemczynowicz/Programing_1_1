using System.Diagnostics.Metrics;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool endNumber = false,leep;
            string output= "";
             do  
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());
                
                leep = (year % 100 != 0 && year % 4 == 0) || year % 400 == 0;
                if (year < 0)
                {
                    Console.WriteLine("Year must be possitive!");
                }
                else if(year !=0)   
                {
                    if (leep)
                    {
                        output = $"{year} is a leep year";
                    }
                    else
                    {
                        output = $"{year} is not a leep year";
                    }

                    Console.WriteLine(output);
                }
                endNumber = year == 0;

            }
            while (!endNumber);

               
           
          

        }
    }
}