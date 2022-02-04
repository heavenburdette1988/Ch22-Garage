using System;

namespace ch22Garage
{
    public class Zero : Vehicle
    {
       public double BatteryKWh { get; set; }
  
    public void ChargeBattery()
        {
            // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you, Yeeeeeoooooowwwww!");        }
    }
}