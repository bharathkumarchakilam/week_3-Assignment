using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Bank
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public static double InterestRate { get; private set; } = 5.0;

        public Bank(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }

    //class Program13
    //{
    //    static void Main()
    //    {
    //        Bank acc1 = new Bank("Alice", 1000);
    //        Bank acc2 = new Bank("Bob", 2000);

    //        Console.WriteLine("Initial Interest Rate:");
    //        acc1.DisplayAccountInfo();
    //        acc2.DisplayAccountInfo();

    //        Bank.SetInterestRate(6.5);

    //        Console.WriteLine("\nAfter Updating Interest Rate:");
    //        acc1.DisplayAccountInfo();
    //        acc2.DisplayAccountInfo();
    //    }
    //}
}
