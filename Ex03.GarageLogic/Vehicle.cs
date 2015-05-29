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

        public abstract int NumOfTires { get; }

        public abstract float MaxTirePressure { get; }

        public abstract List<Tire> Tires { get; protected set; }

        public abstract Engine Engine { get; protected set; }

        public override string ToString()
        {
            return string.Format("LicenseID: {0},\n Model: {1},\n  Tires: {2}", this.LicenseID, this.Model, tiresDetails(Tires));
        }

        public StringBuilder tiresDetails(List<Tire> tires)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tires.Count; i++)
            {
                sb.Append(tires[i].ToString());
            }
            return sb;
        }

        public object currentEnergy { get; set; }
    }
}
