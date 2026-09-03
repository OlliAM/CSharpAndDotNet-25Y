using System;
using Opgave03.model;

namespace Opgave03
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("=== Creating a new BankAccount ===");
                var account = new BankAccount
                {
                    AccountNumber = "DK123456789"
                };

                Console.WriteLine("Setting owner...");
                account.Owner = "Anna Andersen";
                Console.WriteLine($"Owner: {account.Owner}");

                Console.WriteLine("\n=== Testing Deposit ===");
                Console.WriteLine($"Initial balance: {account.Balance}");
                account.Deposit(500);
                Console.WriteLine($"Balance after depositing 500: {account.Balance}");

                account.Deposit(-100); // should be ignored per the guard clause
                Console.WriteLine($"Balance after attempting to deposit -100: {account.Balance}");

                Console.WriteLine("\n=== Testing Withdraw ===");
                account.Withdraw(200);
                Console.WriteLine($"Balance after withdrawing 200: {account.Balance}");

                account.Withdraw(-50); // should be ignored per the guard clause
                Console.WriteLine($"Balance after attempting to withdraw -50: {account.Balance}");

                Console.WriteLine("\n=== Testing Overdraft ===");
                account.Withdraw(10000);
                Console.WriteLine($"Balance after withdrawing 10000: {account.Balance}");
                Console.WriteLine($"Is account overdrawn? {account.isOverdrawn}");

                Console.WriteLine("\n=== Testing FormattedBalance ===");
                Console.WriteLine($"Formatted balance: {account.FormattedBalance}");

                Console.WriteLine("\n=== Testing empty owner (should throw) ===");
                try
                {
                    account.Owner = "";
                    Console.WriteLine("No exception thrown for empty owner.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception caught: {ex.GetType().Name} - {ex.Message}");
                }

                Console.WriteLine("\n=== Testing null owner (should throw) ===");
            try
            {
                account.Owner = null;
                Console.WriteLine("No exception thrown for null owner.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.GetType().Name} - {ex.Message}");
            }

            Console.WriteLine("\n=== Reading Owner after failed set attempts ===");
            Console.WriteLine($"Owner: {account.Owner}");

            Console.WriteLine("\nDone. Press any key to exit.");
            Console.ReadKey();
        }
    }
}