using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    public class GPA
    {
        private List<Grade> grades;

        public GPA ()
        {
            grades = new List<Grade>();
        }

        public void AddGrade(Grade g)
        {
            grades.Add(g);
        }

        public double CalculateGPA()
        {
            double weight = 0;
            double totalCredits = 0;

            foreach(Grade g in grades)
            {
                weight += g.Credits * g.GradePoint;
                totalCredits += g.Credits;
            }

            return weight / totalCredits;
        }

    }
}
