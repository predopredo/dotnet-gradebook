using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Pedro's grade book");

            while (true)
            {   
                // Console.Clear();
                Console.WriteLine("Welcome to GradeBook");
                Console.WriteLine("Enter a grade and press enter or enter 'q' to compute statistics and quit");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    Console.Clear();
                    break;
                }

                book.AddGrade(double.Parse(input));
            }

            var stats = book.GetStatistics();

            Console.WriteLine("Here are your statistics:");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}