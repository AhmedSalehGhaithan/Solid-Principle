using Liskov_Substitution.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This means that a subclass should be able to perform
            //the same functions as its superclass without altering
            //the expected behavior of the program.

            var account = new Before.FixedDepositAccount("Ahmed", 10000);
            account.withdraw(1000);

            var account2 = new After.FixedDepositAccount("Ahmed", 10000);
            //You can't do the following code becouse we use Liskove substitution
            // account2.withdraw(1000);
        }
    }
}
