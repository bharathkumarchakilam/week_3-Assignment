using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    abstract class Shape
    {
        // Abstract method to be implemented by derived classes
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    //class Program4
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter radius of the circle: ");
    //        double radius = Convert.ToDouble(Console.ReadLine());
    //        Shape circle = new Circle(radius);
    //        Console.WriteLine($"Area of Circle: {circle.CalculateArea():F2}");

    //        Console.Write("\nEnter length of the rectangle: ");
    //        double length = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Enter width of the rectangle: ");
    //        double width = Convert.ToDouble(Console.ReadLine());
    //        Shape rectangle = new Rectangle(length, width);
    //        Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea():F2}");
    //    }
    //}
}
