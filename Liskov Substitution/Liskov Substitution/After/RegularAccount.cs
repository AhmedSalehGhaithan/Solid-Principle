using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution.After
{
    public abstract class RegularAccount : Account_LS
    {
        public RegularAccount(string name,decimal balance):base(name,balance)
        {
            Name = name;
            Balance = balance;
        }
        public abstract void withdraw(decimal amount);
    }
}
