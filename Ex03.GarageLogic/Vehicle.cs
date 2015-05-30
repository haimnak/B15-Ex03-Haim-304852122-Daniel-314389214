// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text;

namespace Ex03.GarageLogic
{
    using System.Collections.Generic;

    public enum eVehicleType
    {
         ElectricCar = 1,
         GasCar = 2, 
         ElectricMotorcycle = 3,
         GasMotorcycle = 4,
         Truck = 5
    }
    /*
     * Vehicle class which contains global vehicle traits and methods
     */

    public abstract class Vehicle
    {
        public string LicenseID { get; set; }

        public string Model { get; set; }

        public int NumOfTires { get; set; }

        public float MaxTirePressure { get; set; }

        public List<Tire> Tires { get; set; }

        public Engine Engine { get; set; }

        public override string ToString()
        {
            return string.Format("LicenseID: {0}\nModel: {1}\nTires details: {2}", this.LicenseID, this.Model, TiresDetails(Tires));
        }

        public StringBuilder TiresDetails(List<Tire> tires)
        {
            StringBuilder sb = new StringBuilder();
            int countTires = 1;
            foreach (Tire tire in tires)
            {
                sb.Append("\n" + "Tire " + countTires + "\n" + tire.ToString() + "\n");
                countTires++;
            }
            return sb;
        }

        public float Energy
        {
            get { return Engine.EnergyLevel * 100; }
        }
    }
}
