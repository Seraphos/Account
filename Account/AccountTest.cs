using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    class AccountTest
    {
        public static void Main(string[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.43M);

            Console.WriteLine("Account 1 Balance: {0:C}", account1.Balance);
            Console.WriteLine("Account 2 Balance: {0:C}", account2.Balance);

            decimal depositAmount;

            Console.WriteLine("Enter deposit amount for account 1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Adding {0:C} to account 1 balance\n", depositAmount);

            account1.Credit(depositAmount); //add to account1 balance

            Console.WriteLine("account 1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account 2 balance: {0:C}", account2.Balance);

            Console.WriteLine("Enter deposit amount for account 2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account 2 balance\n", depositAmount);
            account2.Credit(depositAmount);
            Console.WriteLine("Account 1 balance: {0:C}", account1.Balance);
            Console.WriteLine("Account 2 balance: {0:C}", account2.Balance);

            decimal debitAmount1, debitAmount2;

            Console.WriteLine("Enter a debit for account 1: ");
            debitAmount1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter a debit for account2: ");
            debitAmount2 = Convert.ToDecimal(Console.ReadLine());
            account1.Debit(debitAmount1);
            account2.Debit(debitAmount2);

            Console.WriteLine("Account 1 value after debits: {0:C}\nAccount 2 value after debits: {1:C}", account1.Balance, account2.Balance);
            Console.ReadKey();
        }//end main method
    }
}
