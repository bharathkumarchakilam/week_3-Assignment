using System;

namespace week_3
{
    public class BankAccount
    {
        private decimal balance; // Private field

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {balance}");
        }

        public decimal GetBalance()
        {
            return balance; // Only accessible via this method
        }
    }

    //class Program1
    //{
    //    static void Main()
    //    {
    //        BankAccount account = new BankAccount(1000);

    //        account.Deposit(500);
    //        account.Withdraw(300);
    //        account.Withdraw(1500); // Should show insufficient balance

    //        Console.WriteLine($"Final Balance: {account.GetBalance()}");
    //    }
    //}
}
