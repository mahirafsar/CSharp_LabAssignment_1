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
            //1-1 Relation
            //Address address1 = new Address("200","10","Dhaka","Bangladesh");
            //Account account1 = new Account(1001,"Mahir",5000.5,address1);  //address1-> object reference
            //account1.ShowAccountInformation();

            //Account account2 = new Account(2002,"Afsar",3000,new Address(40,30,"Mirpur"));
            //account2.PrintAccount();
            //Console.WriteLine(account2.Address.City); 
            //------------------------*-------------------------------

            //1-* Relation
            Bank ourBank = new Bank("Developer Bank", 5);
            ourBank.AddAccount(new Account("Mahir", 3000, new Address("40", "30", "Mirpur", "Bangladesh")));
            ourBank.AddAccount(new Account("esha", 5000.5, new Address("200", "10", "Dhaka", "Bangladdesh")));
            //ourBank.Accounts[1].Deposit(1000);
            //ourBank.Accounts[0].Withdraw(1000);
            //ourBank.Accounts[0].Transfer(ourBank.Accounts[1], 1000);
            //ourBank.SearchAccount(2002);
           // ourBank.DeleteAccount(1001);
            ourBank.PrintAccountDetails();


        }
    }
}
