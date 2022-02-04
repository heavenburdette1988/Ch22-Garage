using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle
    {
       public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            
            if (CurrentChargePercentage < 100)
            {

            CurrentChargePercentage = 100;

            }
            else
            {
                CurrentChargePercentage = 100;

            }
            
        }




        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you, Yeeeeeoooooowwwww!");        }
    }
}