using System;

namespace Garage
{
        public class Vehicle
{
     public string Name { get; set;}
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual  void Drive()
    {
        Console.WriteLine("Vrooom!");
    }

  
}
}