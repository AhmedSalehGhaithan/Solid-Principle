using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.After
{
    public abstract class Account_LS
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        protected Account_LS(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public abstract void Deposit(decimal amount);
    }
}
