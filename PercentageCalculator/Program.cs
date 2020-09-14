using System;

namespace PercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Result;

            Console.WriteLine("What is the maximum score?");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your score?");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / Maximum;

            if (Result > 100)
            {
                Console.WriteLine("eeeeeee");
            }
            else if (Result >= 90)
            {
                Console.WriteLine("fffffffff");
            }
            else if (Result >= 80)
            {
                Console.WriteLine("hhhhhhhhhh");
            }
            else if (Result > 61)
            {
                Console.WriteLine("jjjjjjj");
            }
            else
                Console.WriteLine("tttttttt");
        }
    }
}
