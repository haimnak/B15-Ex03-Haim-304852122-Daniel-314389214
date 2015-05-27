using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    /*
        * Vehicle satus
        */
    [Flags]
    public enum eVehicleStatuses
    {
        UnderRepair,

        Repaired,

        Paid
    }

    /*
     * A new vehicle arrives at the garage: 
     * Create a vehicle instance and add it to the list
     */
    public class Garage
    {
        public List<string> garageCars = new List<string>();
        // Check if the vehicle is already in the garage acccording to license plate
        // **Do I check here, or do I check outside and then insert?
        // public VehicleArrival(enum type,string license)

        // Get list of allowed vehicle types for garage entry
        // public List<string> GetValidVehicleTypes()


        public bool thisCarInTheGarage(string licenseId)
        {
            bool inGarage = garageCars.Contains(licenseId);
               
            return inGarage;
        }

        public bool getData(string licenseId)
        {
            
        }

        public void refuelVehicle(string licenseId, eFuelType fuelType, float amount)
        {
            throw new NotImplementedException();
        }

        public void rechargeVehicle(string licenseId, float amount)
        {
            throw new NotImplementedException();
        }

        public void InflateTiresToMax(string licenseId)
        {
            throw new NotImplementedException();
        }

        public void updateCarStatus(string licenseId, eVehicleStatuses statusToChange)
        {
            throw new NotImplementedException();
        }

        public List<string> getLicensesIDInTheGarage(eVehicleStatuses status)
        {
            throw new NotImplementedException();
        }

        public void InsertVehicle(object name, object phoneNumber, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
