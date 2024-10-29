using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    public class FourWheeler:Vehicle,IInteriorDesign
    {
        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int NumberOfGear { get; set; }
        public override int EngineCapacityInCC { get; set; }
        public override VehicleType Type { get; set; }
        public FourWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacityInCC, VehicleType type,int numberofseat, int numberofDoor) : base(modelNo, yearMake, numberOfGear, engineCapacityInCC, type)
        {
           ModelNo= modelNo;
           YearMake= yearMake;
           NumberOfGear= numberOfGear;
           EngineCapacityInCC = engineCapacityInCC;
           Type = type;
        }
        public override void GetDetails()
        {
            Console.WriteLine("Details Overridden");
        }

        public string[] GetInteriorDesign(string design)
        {
            string[] designs = design.Split(',');
            return designs;
        }
    }
}
