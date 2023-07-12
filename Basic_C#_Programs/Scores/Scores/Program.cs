using System;
using System.IO;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"Welcome back {uName}. Today is {date}";
            Console.WriteLine(msg);
            Console.ReadLine();

            string path = @"C:\Users\Jacob\Documents\GitHub\Basic-C-Sharp-Projects\Basic_C#_Programs\Scores\Scores\studentScores.txt";
            string[] lines = File.ReadAllLines(path);


            double tScore = 0.0;
            Console.WriteLine("\nStudent Score: \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n total of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
