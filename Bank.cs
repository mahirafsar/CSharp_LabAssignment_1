using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_1
{
    class Bank
    {
        private Account[] myBank;       //one to many relation(Bank has many Accounts)
        private string bankName;
        public Bank(string bankName, int size)
        {
            this.bankName =bankName ;
            this.myBank = new Account[size];
        }
        public string BankName
        {
            set { this.BankName = value; }
            get { return this.BankName; }
        }
        public Account[] Accounts
        {
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
            }
        }
        public void SearchAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].ShowAccountInformation();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("Account not found");
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Account Deleted");
                    flag = 0;
                    for (int j = i; j < myBank.Length - 1; j++)
                    {
                        myBank[j] = myBank[j + 1];
                    }
                    break;
                }
                else
                {
                    flag = 1;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("Account not found");
            }
        }

    }
}
