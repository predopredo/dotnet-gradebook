using System;
using System.Linq;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
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
            return Name;
        }
        public Statistics GetStatistics()
        {
            var stats = new Statistics();

            stats.Average = GetAverage();
            stats.High = GetMax();
            stats.Low = GetMin();

            return stats;
        }
        private List<double> grades;
        public string Name;  //public members always starts with capital letter
    }
}