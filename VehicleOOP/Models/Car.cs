using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    public sealed class Car : FourWheeler
    {
        string brandName;
        int numberOfSeat;
        int numberOfDoor;
        public Car(string brand,string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicleType type, int numberOfSeat, int numberOfDoor) : base(modelNo, yearMake, numberOfGear, engineCapacityInCC, type, numberOfSeat, numberOfDoor)
        {
            this.brandName = brand;
            this.numberOfSeat = numberOfSeat;
            this.numberOfDoor = numberOfDoor;
        }

        public string BrandName { get => brandName; set => brandName = value; }
        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfDoor { get => numberOfDoor; set => numberOfDoor = value; }

        public override void GetDetails()
        {
            Console.WriteLine($"Vehicle Model {ModelNo}\n Make Year {YearMake}\n Number Of Gear {NumberOfGear}\n Engin Capacity in CC {EngineCapacityInCC}\n Vehicle Type {Type}\nNumber of seat {numberOfSeat}\n Number of Door {numberOfDoor}");
        }
    }
}
