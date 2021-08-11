using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Information
{
 class FourWheeler:Vehicle,IInterior
    {

        public int NumberOfDoor { get; set; }
        public int NumberOfGear { get; set; }
        public void DesignInterior(Car car)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Design " + car.vehicleTypes + " Is Car!!");
            Console.WriteLine
            (
                "Car ModelNo:-" + car.ModelNo
                + " Y-" + car.YearMake
                + " Seat-" + car.NumberOfSeat
                + " CC-" + car.EngineCapacityCC
                + " Number  Of Door-" + car.NumberOfDoor
                + " Number Of Gear-" + car.NumberOfGear
            );

        }
    }
}
