using System;
using System.Collections.Generic;
using System.Globalization;

namespace vjezba1
{
    public class BankAccount
    {
        public static Random rand = new Random();

        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public Account AccountType { get; set; }

        public BankAccount()
        {
            AccountNumber = rand.Next(100000000, 999999999).ToString() + rand.Next(100000000, 999999999).ToString();
            AccountBalance = rand.Next(10, 1000);
            AccountType = (Account)rand.Next(0, 3);
        }

        public BankAccount(string AccNum, double AccBalance, Account AccType)
        {
            AccountNumber = AccNum;
            AccountBalance = AccountBalance;
            AccountType = AccountType;
        }
    }


    public class BankAccounts
    {
        public List<BankAccount> AccountList;

        public BankAccounts()
        {
            AccountList = new List<BankAccount>();
        }
        public void Add(BankAccount B)
        {
            AccountList.Add(B);
            Console.WriteLine("Racun dodan");
        }
        public void ShowAll()
        {
            foreach (var B in AccountList)
            {
                Console.WriteLine("Account number: " + B.AccountNumber);
                Console.WriteLine("Account Balance: " + B.AccountBalance.ToString("C", CultureInfo.CurrentCulture));
                Console.WriteLine("Account Type: " + B.AccountType.ToString());
                Console.WriteLine("================================================================================");
            }
        }

    }
    public enum Account
    {
        Stednja,
        TekuciRacun,
        ZiroRacun
    }
}
