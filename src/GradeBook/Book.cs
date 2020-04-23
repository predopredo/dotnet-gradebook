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
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
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
            // var stats = new Statistics();

            // stats.Average = GetAverage();
            // stats.High = GetMax();
            // stats.Low = GetMin();

            // return stats;
            var stats = new Statistics();
            stats.Average = 0.0;
            stats.High = double.MinValue;
            stats.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                stats.Low = Math.Min(grade, stats.Low);
                stats.High = Math.Max(grade, stats.High);
                stats.Average += grade;
            }
            stats.Average /= grades.Count;

            // for (int index = 0; index < grades.Count; index++)
            // {
            //     stats.Low = Math.Min(grades[index], stats.Low);
            //     stats.High = Math.Max(grades[index], stats.High);
            //     stats.Average += grades[index];
            // }
            // stats.Average /= grades.Count;

            // int index = 0;
            // while (index < grades.Count)
            // {
            //     stats.Low = Math.Min(grades[index], stats.Low);
            //     stats.High = Math.Max(grades[index], stats.High);
            //     stats.Average += grades[index];
            //     index++;
            // };
            // stats.Average /= grades.Count;

            // int index = 0;
            // do
            // {
            //     stats.Low = Math.Min(grades[index], stats.Low);
            //     stats.High = Math.Max(grades[index], stats.High);
            //     stats.Average += grades[index];
            //     index++;
            // } while (index < grades.Count);
            // stats.Average /= grades.Count;

            return stats;
        }
        private List<double> grades;
        public string Name;  //public members always starts with capital letter
    }
}