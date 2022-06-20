using System;

namespace FactoryPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How naby wheels will your vehicle have");
            var numberOfWheels = Console.ReadLine();

            iVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            //iVehicle vehicle = new Car();
            //iVehcile  = new Motorcylce();

            vehicle.Drive();


        }
    }
}
