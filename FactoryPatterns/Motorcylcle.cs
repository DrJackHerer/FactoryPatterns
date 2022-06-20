using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    public class Motorcycle : iVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine($"Building a Motorcycle");
        }
        public void Drive()
        {
            Console.WriteLine($"Motorcycle is now driving!\n");
        }
    }
}
