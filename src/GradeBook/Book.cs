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

        // public void AddLetterGrade(char letter)
        // {
        //     switch (letter)
        //     {
        //         case 'A':
        //             AddGrade(90);
        //             break;
        //         case 'B':
        //             AddGrade(80);
        //             break;
        //         case 'C':
        //             AddGrade(70);
        //             break;
        //         case 'D':
        //             AddGrade(70);
        //             break;
        //         case 'E':
        //             AddGrade(60);
        //             break;
        //         case 'F':
        //             AddGrade(50);
        //             break;
        //         default: 
        //             AddGrade(0);
        //             break;
        //     }
        // }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}. It should be between 0 and 100");
            }
        }
        public bool HasGrades() {
            return grades.Count > 0;
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

            // var stats = new Statistics();
            // stats.Average = 0.0;
            // stats.High = double.MinValue;
            // stats.Low = double.MaxValue;

            // foreach (double grade in grades)
            // {
            //     stats.Low = Math.Min(grade, stats.Low);
            //     stats.High = Math.Max(grade, stats.High);
            //     stats.Average += grade;
            // }
            // stats.Average /= grades.Count;

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

            switch (stats.Average)
            {
                case var average when average >= 95.0:
                    stats.Letter = "A+";
                    break;

                case var average when average >= 90.0:
                    stats.Letter = "A";
                    break;

                case var average when average >= 80.0:
                    stats.Letter = "B";
                    break;

                case var average when average >= 70.0:
                    stats.Letter = "C";
                    break;

                case var average when average >= 60.0:
                    stats.Letter = "D";
                    break;

                default:
                    stats.Letter = "F";
                    break;
            }

            return stats;
        }
        private List<double> grades;
        public string Name;  //public members always starts with capital letter
    }
}