using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Information
{
    class Program
    {
        static void Main(string[] args)
        {//Vehicle v = new Vehicle(); // you can't intiated this Vehicle class becasue it is a abstract class
            // in this case you will get a compile time error

            Console.WriteLine("choose vehicle:");
            Console.WriteLine("input '4' for car or input '2' for motorcycle");
            int vehicleType = Convert.ToInt32(Console.ReadLine());
            if (vehicleType == (int)VehicleType.FourWheeler)
            {
                Car car = new Car();
                Console.WriteLine("input CC:");
                car.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("Year Make:");
                car.YearMake = int.Parse(Console.ReadLine());
                Console.WriteLine("Model no:");
                car.ModelNo = Console.ReadLine();
                Console.WriteLine("Number of Door:");
                car.NumberOfDoor = int.Parse(Console.ReadLine());
                Console.WriteLine("Number of Gear:");
                car.NumberOfGear = int.Parse(Console.ReadLine());
                IInterior interior = new FourWheeler();
                interior.DesignInterior(car);
            }
            else if (vehicleType == (int)VehicleType.TwoWheeler)
            {
                Motorcycle oMotorcycle = new Motorcycle();
                Console.WriteLine("input CC:");
                oMotorcycle.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("input Milage:");
                oMotorcycle.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("input Model Number:");
                oMotorcycle.ModelNo = Console.ReadLine();
                Console.WriteLine("input Year:");
                oMotorcycle.YearMake = int.Parse(Console.ReadLine());

                IExterior iExterior = new TwoWheeler();
                iExterior.DesignExterior(oMotorcycle);
            }
            else
            {
                Console.WriteLine("vehicle not found.");
            }

            Console.ReadLine();
        }
    }
    }

