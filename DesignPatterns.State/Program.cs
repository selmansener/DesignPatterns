using System;

namespace DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
