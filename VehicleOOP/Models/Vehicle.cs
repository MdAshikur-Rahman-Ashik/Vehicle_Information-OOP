using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    public abstract class Vehicle
    {
        string modelNo;
        int yearMake;
        int numberOfGear;
        int engineCapacityInCC;
        VehicleType type;
        public abstract string ModelNo { get; set; }
        public abstract int YearMake { get; set; }
        public abstract int NumberOfGear { get; set; }
        public abstract int EngineCapacityInCC { get; set; }
        public abstract VehicleType Type { get; set; }
        public Vehicle()  { }
        protected Vehicle(string mNo, int yMake, int numGear, int engineCap, VehicleType type)
        {
            this.modelNo = mNo;
            this.yearMake = yMake;
            this.numberOfGear = numGear;
            this.engineCapacityInCC = engineCap;
            this.type = type;
        }       
        public abstract void GetDetails();

    }
}
