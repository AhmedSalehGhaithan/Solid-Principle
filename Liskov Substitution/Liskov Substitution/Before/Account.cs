using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.Before
{
    public abstract class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        protected Account(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public abstract void Deposit(decimal amount);

        public abstract void withdraw(decimal amount);
    }
}
