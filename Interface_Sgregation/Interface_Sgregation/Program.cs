using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sgregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = After.Repository.LoadEmployees();

            foreach(var e in employees)
            {
                Console.WriteLine(e.PrintSalarySlip());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
