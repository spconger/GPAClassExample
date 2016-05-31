using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    public class Display
    {
        GPA gpa = new GPA();

        public Display()
        {
            GetGrades();
        }
        public void GetGrades()
        {
            Console.WriteLine("How many grades do you want to enter?");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Grade g = new Grade();
                Console.WriteLine("Enter the Gradepoint");
                g.GradePoint = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Credits");
                g.Credits = int.Parse(Console.ReadLine());

                gpa.AddGrade(g);
            }//end for
            GetGPA();
        }//end getGrades

        public void GetGPA()
        {
            Console.WriteLine("You GPA is {0}", gpa.CalculateGPA());
        }
    }
}
