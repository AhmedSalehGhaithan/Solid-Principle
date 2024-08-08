using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sgregation.Before
{

     class DayLabourer : Employee, IEntitlement
    {
        public decimal CalculateBonuses()=>
            throw new NotSupportedException("Day labourer Bonuses not suported");


        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() =>
            throw new NotSupportedException("Day labourer Pension not suported");


        public decimal CalculateRentalSubsidy() =>
            throw new NotSupportedException("Day labourer subsidy not suported");


        public decimal CalculateTransportationReimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateTransportationReimbursement();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(DayLabourer)} ---" +
                   $"\n  No. : {EmployeeNo}" +
                   $"\n  Name : {Name}" +
                   $"\n  Basic Salary : {Salary.ToString("C2")}" +
                   $"\n  Transporation Reimbursement : {CalculateTransportationReimbursement().ToString("C2")}" +
                   $"\n -----------------------------------------" +
                   $"\n NetSalary : {CalculateNetSalary().ToString("C2")}";
        }
    }
}
