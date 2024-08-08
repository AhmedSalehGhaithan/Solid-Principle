using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example_Two
{
    public class Student
    {
        public string Name { get; set; }
        public Dictionary<string, double> CoursesAndGrades = new Dictionary<string, double>();
        public void EnrollCourse(string courseName)
        {
            CoursesAndGrades[courseName] = 0; // default grade
        }
        public void AssignGrade(string courseName, double grade)
        {
            if (CoursesAndGrades.ContainsKey(courseName))
            {
                CoursesAndGrades[courseName] = grade;
            }
        }
    }
}
