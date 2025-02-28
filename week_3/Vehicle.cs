using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    using System;

    class Vehicle
    {
        // Virtual method to be overridden by derived classes
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    class Car : Vehicle
    {
        // Overriding the Start method for Car
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key or push button...");
        }
    }

    class Bike : Vehicle
    {
        // Overriding the Start method for Bike
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a kick or self-start...");
        }
    }

    //class Program5
    //{
    //    static void Main()
    //    {
    //        // Demonstrating polymorphism
    //        Vehicle myVehicle;

    //        myVehicle = new Car();
    //        myVehicle.Start(); // Calls Car's Start() method

    //        myVehicle = new Bike();
    //        myVehicle.Start(); // Calls Bike's Start() method
    //    }
    //}

}
