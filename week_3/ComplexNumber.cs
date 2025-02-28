using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
        }
    }

    //class Program11
    //{
    //    static void Main()
    //    {
    //        ComplexNumber c1 = new ComplexNumber(3, 4);
    //        ComplexNumber c2 = new ComplexNumber(1, 2);

    //        ComplexNumber result = c1 + c2;

    //        Console.WriteLine($"First Complex Number: {c1}");
    //        Console.WriteLine($"Second Complex Number: {c2}");
    //        Console.WriteLine($"Sum: {result}");
    //    }
    //}
}
