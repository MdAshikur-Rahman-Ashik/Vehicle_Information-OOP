using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
			finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many times you want to do the operation?");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Select Operation\n1 ---Car\n2 ---Motor Cycle");
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        PrintCar();
                        break;
                    case 2:
                        PrintMotorCycle();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            }
            

            
        }

        private static void PrintMotorCycle()
        {
            // Updated Motorcycle specifications
            string brand = "Honda";
            string model = "CBR 500R";
            int yearmake = 2023;
            int engine = 471;
            int gear = 6;
            double maximumPowerinBPH = 47.6;
            int maximumTorqueinNM = 43;
            int mileageinKMPL = 30;
            string frontBrake = "ABS Disc Brake";
            string rearBrake = "Disc Brake";
            VehicleType vehicleType = VehicleType.Sports;

            MotorCycle cycle = new MotorCycle(brand, model, yearmake, gear, engine, vehicleType, maximumPowerinBPH, maximumTorqueinNM, mileageinKMPL, frontBrake, rearBrake);

            cycle.GetDetails();
            string start = cycle.StartMethod("Vroom...");
            Console.WriteLine(start);
            string cooling = cycle.Cooling("Liquid Cooling System Enabled");
            Console.WriteLine(cooling);
            Console.WriteLine();
            Console.WriteLine("Exterior Design");
            Console.WriteLine("-----------------");

            // Updated Exterior Design
            string[] extDesign = cycle.GetExteriorDesign("LED Headlights, Frame Sliders, Windshield, Tank Pad, Tail Tidy");
            for (int i = 0; i < extDesign.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + extDesign[i]);
            }
        }

        private static void PrintCar()
        {
            // Updated Car specifications
            string brand = "Toyota";
            string model = "Corolla";
            int yearmake = 2021;
            int engine = 1800;
            int gear = 6;
            int door = 4;
            int seat = 5;
            VehicleType type = VehicleType.Family;

            Car car = new Car(brand, model, yearmake, gear, engine, type, seat, door);
            car.GetDetails();

            Console.WriteLine("Interior Design");
            Console.WriteLine("-----------------");

            // Updated Interior Design
            string[] carDesign = car.GetInteriorDesign("Leather Seats, Touchscreen Display, Rearview Camera, Bluetooth, Sunroof");
            for (int i = 0; i < carDesign.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + carDesign[i].Trim());
            }
        }

    }
}
