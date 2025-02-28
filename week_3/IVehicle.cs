using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    interface IVehicle
    {
        void Drive();
    }

    class Bikes : IVehicle
    {
        public void Drive() => Console.WriteLine("Bike is riding...");
    }

    class Cars : IVehicle
    {
        public void Drive() => Console.WriteLine("Car is driving...");
    }

    class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheels) =>
            wheels == 2 ? new Bikes() :
            wheels == 4 ? new Cars() :
            throw new ArgumentException("Invalid number of wheels.");
    }

    //class Program16
    //{
    //    static void Main()
    //    {
    //        Console.Write("Enter number of wheels (2/4): ");
    //        int wheels = int.Parse(Console.ReadLine());

    //        try
    //        {
    //            IVehicle vehicle = VehicleFactory.GetVehicle(wheels);
    //            vehicle.Drive();
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}
}
