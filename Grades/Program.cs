using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90.5);
            book.AddGrade(85.5);
            book.AddGrade(75.5);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("List of Grades in the Grade Book");
            book.DisplayGradeBook();
            Console.WriteLine("Average Grade " + stats.AverageGrade);
            Console.WriteLine("Highest Grade " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade " + stats.LowestGrade);
        }
    }
}
