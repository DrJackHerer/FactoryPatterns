using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    public class Cars : iVehicle
    {
        public Cars()
        {
            Console.WriteLine($"Building a new Car");
        }
        public void Drive()
        {
            Console.WriteLine($"Car is now driving");
        }
    }
}
