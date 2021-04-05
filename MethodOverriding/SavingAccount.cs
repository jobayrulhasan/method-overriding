using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class SavingAccount:BankAccount
    {
        public double Interest { get; set; }

        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return "Withdrawn";
            }
            return "Insufficient fund";
        }
    }
}
