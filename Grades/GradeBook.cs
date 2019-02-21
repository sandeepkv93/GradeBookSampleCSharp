using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        List<double> grades;
        public GradeBook()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            double sum = grades.AsParallel().Aggregate((x, y) => x + y);
            stats.HighestGrade = grades.Max();
            stats.LowestGrade = grades.Min();
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void DisplayGradeBook()
        {
            grades.ForEach(grade => Console.WriteLine(grade));
        }
    }
}
