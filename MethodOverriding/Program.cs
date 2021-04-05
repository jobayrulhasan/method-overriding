using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========Output for the saving account========");
            SavingAccount save = new SavingAccount();
            save.CustomerName = "Sharif Uddin";
            save.AccountNo = "SAV-12543";
            Console.Write("Enter Interest charge : ");
            double service0 = Convert.ToDouble(Console.ReadLine());
            save.Interest = service0;
            Console.Write("Enter deposit amount for saving account : ");
            double service1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(save.Deposit(service1));
            Console.Write("Enter withdraw amount for saving amount : ");
            double service2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(save.Withdraw(service2));
            Console.WriteLine("\n========Output for the cecking account========");
            CeckingAccount ceck = new CeckingAccount();
            ceck.AccountNo = "CH-14520";
            ceck.CustomerName = "Shafali Khan";
            Console.Write("Enter service charge : ");
            double service = Convert.ToDouble(Console.ReadLine());
            ceck.ServiceCharge = service;
            Console.Write("Enter deposit amount for cecking account : ");
            double service3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter withdraw amount for cecking amount : ");
            double service4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Deposited amount : {0}",ceck.Deposit(service3));
            Console.WriteLine("Cecking withdraw amount : {0}",ceck.Withdraw(service4));
            Console.WriteLine("============Thank you=============");
            Console.ReadKey();
        }
    }
}
