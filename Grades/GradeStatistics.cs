using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{

    public class GradeStatistics
    {
        public double AverageGrade;
        public double HighestGrade;
        public double LowestGrade;
        public GradeStatistics()
        {
            this.HighestGrade = 0.0;
            this.LowestGrade = double.MaxValue;
        }
    }
}
