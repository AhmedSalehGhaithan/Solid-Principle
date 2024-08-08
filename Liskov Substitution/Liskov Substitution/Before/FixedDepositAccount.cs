using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Before
{// in this bussiness it is not allowed to withdraw 
    // so the withdraw function her is not doing the same logic as the super class
    // so we then use the Liskov Substitution principle
    public class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name, decimal balance):base(name,balance)
        {
            
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void withdraw(decimal amount)
        {
            throw new NotSupportedException($"You can not withdraw for fixed deposit Account !!");
        }
    }
}
