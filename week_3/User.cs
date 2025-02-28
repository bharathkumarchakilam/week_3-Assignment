using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username} has general user access.");
        }
    }

    class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Admin) has full access to all system features.");
        }
    }

    class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Customer) has limited access to basic features.");
        }
    }

    //class Program10
    //{
    //    static void Main()
    //    {
    //        User admin = new Admin("Alice");
    //        User customer = new Customer("Bob");

    //        admin.AccessControl();
    //        customer.AccessControl();
    //    }
    //}
}
