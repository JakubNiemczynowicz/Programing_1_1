using System.Globalization;
using System.Transactions;

namespace assignment7
{
    internal class Program
    {
        const double BmiMinimumMale = 20;
        const double BmiMaximumMale = 25;
        const double BmiMinimumFemale = 19;
        const double BmiMaximumFemale = 24;



        static double weightFromBmi(double bmi, double lenght)
        {
            return bmi * lenght/100 * lenght/100;
        }


        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;



            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter lenght (cm): ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            double bmi = weight / (lenght / 100 * lenght / 100);
            double bmiMax=0;
            double bmiMin=0;
            double weightMax=0;
            double weightMin = 0;

            Console.WriteLine("");
            Console.WriteLine($"bmi-value: {bmi:0.0}");

            if (gender == "male")
            {
                bmiMin = BmiMinimumMale;
                bmiMax = BmiMaximumMale;
                weightMin = weightFromBmi(bmiMin, lenght);
                weightMax = weightFromBmi(bmiMax, lenght);
            }
            else if (gender == "female")
            {
                bmiMin = BmiMinimumFemale;
                bmiMax = BmiMaximumFemale;
                weightMin = weightFromBmi(bmiMin, lenght);
                weightMax = weightFromBmi(bmiMax, lenght);
            }

            Console.WriteLine($"normal bmi-values (min .. max): {bmiMin}..{bmiMax}");
            Console.WriteLine($"healthy weight range: {weightMin:0.0}..{weightMax:0.0}");
        }
    }
}