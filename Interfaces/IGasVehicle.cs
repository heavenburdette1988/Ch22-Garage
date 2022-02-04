
namespace Garage
{

    public interface IGasVehicle
    {

    public string Name { get; set;}
     public double FuelCapacity { get; set; }
  
    public void RefuelTank();


        public int CurrentTankPercentage {get; set;}
        
    }
    }