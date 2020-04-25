using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Pedro's grade book");
            Console.Clear();
            Console.WriteLine("Welcome to GradeBook");

            while (true)
            {
                Console.WriteLine("Enter a grade and press enter or enter 'q' to compute statistics and quit");
                string input = Console.ReadLine();

                if (input.ToLower() == "q" && book.HasGrades())
                {
                    Console.Clear();
                    break;
                }
                else if (input.ToLower() == "q")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter at least one grade");
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    Console.Clear();
                    Console.WriteLine($"Grade Added: {input}");
                }
                catch (ArgumentException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
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