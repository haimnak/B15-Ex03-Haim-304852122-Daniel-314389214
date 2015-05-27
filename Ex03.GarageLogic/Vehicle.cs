using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum eVehicleType
    {
        ElectricCar = 1,
        GasCar = 2,
        ElectricMotorcycle = 3,
        GasMotorcycle = 4,
        Truck = 5,
        Exit = 0
    }
    /*
       * Vehicle class which contains global vehicle traits and methods
       */
    public class Vehicle
    {
        public string LicenseID { get; private set; }

        public string Model { get; private set; }

        public float EnergyPercentage { get; set; }

        public List<Tire> Tires { get; set; }

        public Engine Engine { get; set; }

        public override string ToString()
        {
            return string.Format("LicenseID: {0}, Model: {1}, EnergyPercentage: {2}, Tires: {3}", this.LicenseID, this.Model, this.EnergyPercentage, this.Tires);
        }
    }
}
