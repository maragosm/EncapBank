using System;

namespace BankEncap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the First National Bank of C#");
            Console.WriteLine("To continue, enter your account ID: ");
            var account1 = new BankAccount() { AccountID = Console.ReadLine() };
            Console.WriteLine("Press 1 to view your balance. Press 2 to make a deposit. Press 3 to make a withdrawal.");
            Console.Write("Action: ");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    account1.BalanceCheck();
                    break;
                case "2":
                    Console.WriteLine("How many dollars would you like to deposit?");
                    Console.Write("Amount: ");
                    var depoAmount = Convert.ToInt32(Console.ReadLine());
                    account1.Deposit(depoAmount);
                    break;
                case "3":
                    Console.WriteLine("How many dollars would you like to withdraw?");
                    Console.Write("Amount: ");
                    var withdrawAmount = Convert.ToInt32(Console.ReadLine());
                    account1.Withdraw(withdrawAmount);
                    break;
                default:
                    do
                    {
                        Console.WriteLine("Please enter a valid input to continue");
                        Console.Write("Input: ");
                        userInput = Console.ReadLine();
                    } while (userInput != "1" && userInput != "2" && userInput != "3");
                    break;
            }

            Console.WriteLine("Thank you for using the First National Bank of C# application!");

        }
    }
}
