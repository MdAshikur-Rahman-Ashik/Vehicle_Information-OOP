using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    public sealed class MotorCycle : TwoWheeler
    {
        string brandName;
        double maximumPowerinBPH;
        int maximumTorqueinNM;
        int mileageinKMPL;
        string frontBrake;
        string rearBrake;
        public MotorCycle(string brand,string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicleType type, double maximumPowerinBPH, int maximumTorqueinNM, int mileageinKMPL, string frontBrake, string rearBrake) : base(modelNo, yearMake, numberOfGear, engineCapacityInCC, type, maximumPowerinBPH, maximumTorqueinNM, mileageinKMPL, frontBrake, rearBrake)
        {
            this.brandName = brand;
            this.maximumPowerinBPH = maximumPowerinBPH;
            this.maximumTorqueinNM=maximumTorqueinNM;
            this.frontBrake=frontBrake;
            this.rearBrake=rearBrake;
            this.mileageinKMPL=mileageinKMPL;
        }

      
        public double MaximumPowerinBPH { get => maximumPowerinBPH; set => maximumPowerinBPH = value; }
        public int MaximumTorqueinNM { get => maximumTorqueinNM; set => maximumTorqueinNM = value; }
        public int MileageinKMPL { get => mileageinKMPL; set => mileageinKMPL = value; }
        public string FrontBrake { get => frontBrake; set => frontBrake = value; }
        public string RearBrake { get => rearBrake; set => rearBrake = value; }
        public string BrandName { get => brandName; set => brandName = value; }

        public override void GetDetails()
        {
            Console.WriteLine($"\n Vehicle Model {ModelNo}\n Make Year {YearMake}\n Number Of Gear {NumberOfGear}\n Engin Capacity in CC {EngineCapacityInCC}\n Maximum power of BPH {maximumPowerinBPH}\n Maximum Torque In NM {maximumTorqueinNM}\n Mileage In KMPL {mileageinKMPL}\n Front Brake {frontBrake}\n Rear Brake {rearBrake}\n Vehicle Type {Type}");
        }
    }
}
