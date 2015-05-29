// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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

        public Engine Engine { get; protected set; }

        public override string ToString()
        {
            return string.Format("LicenseID: {0}, Model: {1}, Tires: {2}", this.LicenseID, this.Model, this.Tires);
        }
    }
}
