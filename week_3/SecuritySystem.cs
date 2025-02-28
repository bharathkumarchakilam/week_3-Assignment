using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    sealed class SecuritySystem
    {
        private string Password = "secure123";

        public bool Authenticate(string inputPassword)
        {
            return inputPassword == Password;
        }
    }

    //class Program14
    //{
    //    static void Main()
    //    {
    //        SecuritySystem system = new SecuritySystem();

    //        Console.Write("Enter Password: ");
    //        string inputPassword = Console.ReadLine();

    //        if (system.Authenticate(inputPassword))
    //            Console.WriteLine("Access Granted.");
    //        else
    //            Console.WriteLine("Access Denied.");
    //    }
    //}
}
