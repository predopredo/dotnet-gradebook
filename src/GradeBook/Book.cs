using System;
using System.Linq;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public double GetMin()
        {
            return Enumerable.Min(grades);
        }
        public double GetMax()
        {
            return Enumerable.Max(grades);
        }
        public double GetAverage()
        {
            return Enumerable.Average(grades);
        }
        public string GetName()
        {
            return name;
        }
        public void GetStats()
        {
            Console.WriteLine($"{GetName()}:");
            Console.WriteLine($"The lowest grade is {GetMin()}");
            Console.WriteLine($"The highest grade is {GetMax()}");
            Console.WriteLine($"The average grade is {GetAverage()}");
        }
        private List<double> grades;
        private string name;
    }
}