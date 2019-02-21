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
        public string Name;
        public GradeBook()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        private static double GetMedian(double[] sourceNumbers)
        {
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new System.Exception("Median of empty array not defined.");

            //make sure the list is sorted, but use a new array
            double[] sortedPNumbers = (double[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);

            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            double sum = grades.AsParallel().Aggregate((x, y) => x + y);
            stats.HighestGrade = grades.Max();
            stats.LowestGrade = grades.Min();
            stats.AverageGrade = sum / grades.Count;
            stats.MedianGrade = GetMedian(grades.ToArray());
            return stats;
        }

        public void DisplayGradeBook()
        {
            grades.ForEach(grade => Console.WriteLine(grade));
        }
    }
}
