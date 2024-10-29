using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    public class TwoWheeler:Vehicle,IExteriorDesign
    {     

        public TwoWheeler(string modelNo,int yearMake,int numberOfGear, int engineCapacityInCC, VehicleType type, double maximumPowerinBPH, int maximumTorqueinNM, int mileageinKMPL, string frontBrake, string rearBrake):base( modelNo,  yearMake,  numberOfGear,  engineCapacityInCC,  type)
        {

            ModelNo = modelNo;
            YearMake = yearMake;
            NumberOfGear = numberOfGear;
            EngineCapacityInCC = engineCapacityInCC;
            Type = type;
          
        }

       
        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int NumberOfGear { get; set; }
        public override int EngineCapacityInCC { get; set; }
        public override VehicleType Type { get; set; }

        public string StartMethod(string start= "Started")
        {
            return start;
        }
        public string Cooling(string cool= "System abailable")
        {
            return cool;
        }

        public string[] GetExteriorDesign(string design)
        {
            string[] designs= design.Split(',');
            return designs;
        }

        public override void GetDetails()
        {
            Console.WriteLine("Method Overridden");
        }
    }
}
