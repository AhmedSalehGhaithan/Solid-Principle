using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sgregation.Before
{
   static class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Staff
                {
                    EmployeeNo = "201854-g5-5421",
                    Name = "Ali gasser",
                    Salary = 1000
                },
                new Consultant
                {
                    EmployeeNo = "54210-wd5-878",
                    Name = "Mohamed ghaithan",
                    Salary = 1000
                },
                new DayLabourer
                {
                    EmployeeNo = "547-l5-87854",
                    Name = "Ahmed ghaithan",
                    Salary = 1000
                }
            };
        }
    }
}
