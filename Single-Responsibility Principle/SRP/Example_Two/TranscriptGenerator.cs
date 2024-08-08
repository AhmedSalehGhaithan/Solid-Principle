using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example_Two
{
    public class TranscriptGenerator
    {
        private GPACalculator _gpaCalculator;
        public TranscriptGenerator(GPACalculator gpaCalculator)
        {
            _gpaCalculator = gpaCalculator;
        }
        public void PrintTranscript(Student student)
        {
            Console.WriteLine($"Transcript for {student.Name}");
            foreach (var course in student.CoursesAndGrades)
            {
                Console.WriteLine($"{course.Key}: {course.Value}");
            }
            Console.WriteLine($"GPA: {_gpaCalculator.CalculateGPA(student)}");
        }
    }
}
