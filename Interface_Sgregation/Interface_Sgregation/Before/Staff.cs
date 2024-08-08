using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sgregation.Before
{
     class Staff : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => Salary + 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() => .25m * Salary;

        public decimal CalculateRentalSubsidy() => 150;

        public decimal CalculateTransportationReimbursement() =>
            throw new NotSupportedException("Staff Pension not suported");

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(DayLabourer)} ---" +
                   $"\n  No. : {EmployeeNo}" +
                   $"\n  Name : {Name}" +
                   $"\n  Basic Salary : {Salary.ToString("C2")}" +
                   $"\n -----------------------------------------" +
                   $"\n NetSalary : {CalculateNetSalary().ToString("C2")}";
        }

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateBonuses()
                + CalculateHealthInsurance()
                + CalculatePension()
                + CalculateRentalSubsidy();
        }
    }
}
