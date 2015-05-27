// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{
    using System.Collections.Generic;

    /*
     * Vehicle class which contains global vehicle traits and methods
     */
    public abstract class Vehicle
    {
        public string LicenseID { get; private set; }

        public string Model { get; private set; }

        public List<Tire> Tires { get; protected set; }

        public Engine Engine { get; protected set; }

        public override string ToString()
        {
            return string.Format("LicenseID: {0}, Model: {1}, EnergyPercentage: {2}, Tires: {3}", this.LicenseID, this.Model, this.EnergyPercentage, this.Tires);
        }
    }
}
