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
        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = GetAverage();
            result.High = GetMax();
            result.Low = GetMin();

            return result;
        }
        private List<double> grades;
        private string name;
    }
}