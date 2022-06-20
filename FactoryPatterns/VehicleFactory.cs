using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    public static class VehicleFactory
    {
        public static iVehicle GetVehicle(string wheels)
        {
            switch (wheels)
            {
                case "4":
                case "four":
                    return new Cars();
                case "2":
                case "two":
                    return new Motorcycle();
                default:
                    return new Cars();

            }

            
        }
    }
}

//vehicle car2 = newCar();
//vehicle moto2 = newMotorcycle();