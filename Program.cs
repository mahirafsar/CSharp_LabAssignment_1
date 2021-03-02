using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bank ourBank = new Bank("Developer Bank", 5);
            ourBank.AddAccount(new Account("Mahir", 5000, new Address("40", "30", "Mirpur", "Bangladesh")));
            ourBank.AddAccount(new Account("Afsar", 3000, new Address("200", "10", "Dhaka", "Bangladdesh")));
            ourBank.Accounts[0].Deposit(1000);
            ourBank.Accounts[1].Withdraw(1000);
            ourBank.Accounts[1].Transfer(ourBank.Accounts[0], 1000);
           // ourBank.DeleteAccount(10002);
            ourBank.PrintAccountDetails();
            ourBank.DeleteAccount(10001);
            ourBank.PrintAccountDetails();


        }
    }
}
