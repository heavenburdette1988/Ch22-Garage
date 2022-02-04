using System;

namespace ch22Garage
{
    public class Cessna : Vehicle
    {
    
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }



    
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane, TheZoooooom!");
        }
    }

    }