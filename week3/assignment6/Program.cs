namespace assignment6
{
    internal class Program
    {
        const int ScoreForA = 90;
        const int ScoreForB = 80;
        const int ScoreForC = 70;
        const int ScoreForD = 60;
        //Curse requiment = C grade
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            char grade;

            if (score >= ScoreForA)
            {
                grade = 'A';
            }
            else if (score >= ScoreForB)
            {
                grade = 'B';
            }
            else if (score >= ScoreForC)
            {
                grade = 'C';
            }
            else if (score >= ScoreForD)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine("");
            Console.WriteLine($"grade: {grade}");
            string ifPassed;
            if (score >= ScoreForC)
            {
                ifPassed = "course passed";
            }
            else
            {
                ifPassed = "course not passed";
            }
            Console.WriteLine(ifPassed);

        }
    }
}