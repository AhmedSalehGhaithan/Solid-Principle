using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example_Two
{
    public class GPACalculator
    {
        public double CalculateGPA(Student student)
        {
            // Basic GPA calculation logic
            return student.CoursesAndGrades.Values.Average();
        }
    }
}
