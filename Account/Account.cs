using System;

namespace Account
{
    class Account
    {
        private decimal balance; //instance variable, stores balance

        //contructor
        public Account(decimal initialBalance) { Balance = initialBalance; } //end DecimalType Constructor

        //credit (add) an amount to the account
        public void Credit(decimal amount) { Balance = Balance + amount; } //end Credit method

        //a property to get & set the account balance
        public decimal Balance
        {
            get { return balance; } //end get
            set
            {   //validate that the value is greater than or equal to 0;
                //if not, the balance is unchanged.
                if (value >= 0) balance = value;
            }//end set
        }//end Balance method

        public void Debit(decimal amount)
        {
            if (amount >= balance)
            {
                amount = 0;
                Console.WriteLine("Debit amount exceeded balance. \nNo change made to the balance on this account.");
            }
            balance = balance - amount;
        }//end debit method

    }
}
