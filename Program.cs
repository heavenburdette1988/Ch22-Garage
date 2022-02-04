using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero(){ 
                Name = "Fxs Zero",
                 CurrentChargePercentage = 100
            };
            Zero fx = new Zero() {
                Name = "Fx Zero",
                 CurrentChargePercentage = 75
            };
            Tesla modelS = new Tesla(){
                Name = "ModelS Tesla",
                CurrentChargePercentage = 50
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            
            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.Name} charge is {ev.CurrentChargePercentage}.");
            }



            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.Name} battery is charged {ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram (){
                  Name = "Ram",
                CurrentTankPercentage = 100
            };
            Cessna cessna150 = new Cessna (){
                  Name = "Cessna 150",
                CurrentTankPercentage = 75
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.Name} tank is {gv.CurrentTankPercentage} %");
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.Name} is now charged to {gv.CurrentTankPercentage}%");
            }
        }
    }
}









