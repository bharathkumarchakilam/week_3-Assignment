using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Calculator
    {
        // Overloaded method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    //class Program7
    //{
    //    static void Main()
    //    {
            //Calculator calc = new Calculator();

            //// Demonstrating method overloading
            //Console.WriteLine("Addition of two integers: " + calc.Add(5, 10));
            //Console.WriteLine("Addition of three integers: " + calc.Add(5, 10, 15));
            //Console.WriteLine("Addition of two double values: " + calc.Add(5.5, 10.2));
    //    }
    //}
}
