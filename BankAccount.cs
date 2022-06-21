using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncap
{
    public class BankAccount
    {
        private double Balance = 0;
        public string AccountID { get; set; }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"You have successfully deposited ${amount} to your account. Your new balance is {Balance}");
        }

        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
            if (Balance > 0)
            {
                Console.WriteLine($"You have successfully withdrew ${amount} to your account. Your new balance is {Balance}");
            }
            else if (Balance < 0)
            {
                var loan = Balance;
                Console.WriteLine($"You have successfully taken out a loan for {loan} and your Balance is $0.");
                Balance = 0;
                Console.WriteLine($"Current interest rates are compounding at 38.4%, enjoy your life of debt!");
            }
            
        }

        public void BalanceCheck()
        {
            Console.WriteLine($"Your current balance is ${Balance}");
        }

    }

}
