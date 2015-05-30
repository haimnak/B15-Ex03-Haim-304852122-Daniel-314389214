// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text;

namespace Ex03.GarageLogic
{
    using System;
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

        public float Energy
        {
            get
            {
                return Engine.EnergyLevel * 100;
            }
        }

        public override string ToString()
        {
            return string.Format("LicenseID: {0},\n Model: {1},\n  Tires: {2},\n  Engine: {2}", this.LicenseID, this.Model, TiresDetails(Tires));
        }

        public string EngineDetails()
        {
            string engineDetails = string.Empty;
            Electric electricEngine = Engine as Electric;

            if (electricEngine == null)
            {
                Fuel fuelEngine = Engine as Fuel;
                if (fuelEngine != null)
                {
                    engineDetails = fuelEngine.ToString();
                }
            }
            else
            {
                engineDetails = electricEngine.ToString();
            }
            return engineDetails;
        }

        public StringBuilder TiresDetails(List<Tire> tires)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Tire tire in tires)
            {
                sb.Append(tire.ToString());
            }
            return sb;
        }
    }
}
