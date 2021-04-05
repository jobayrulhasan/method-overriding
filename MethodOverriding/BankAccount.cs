using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
   public class BankAccount
   {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Diposited";
        }
        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }
    }
}
