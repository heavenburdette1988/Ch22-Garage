using System;

namespace ch22Garage
{
    public class Tesla : Vehicle
    {
       public double BatteryKWh { get; set; }
  
    public void ChargeBattery()
        {
            // method definition omitted
        }


        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} blazes by you, MMMmmmmmmm!");        }
    }
}