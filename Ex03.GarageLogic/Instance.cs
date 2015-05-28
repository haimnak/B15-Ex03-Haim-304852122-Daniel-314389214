using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{


    /*
     * Creates object instances
     */

    public class Instance
    {

        public OwnerDetails Owner(string i_OwnerName, string i_OwnerNumber)
        {
            return new OwnerDetails(i_OwnerName, i_OwnerNumber);
        }

        public static Vehicle CreateVehicle(
            eVehicleType i_VehicleType,
            string i_VehicleModel,
            string i_LicenseID,
            float i_Energy,
            Dictionary<string, object> i_VehicleDetails)
        {
            Vehicle vehicle = null;
            eVehicleType vehicleType = i_VehicleType;

            switch (i_VehicleType)
            {
                case eVehicleType.ElectricCar:
                    vehicle = new ElectricCar(
                        //TODO: Fix parameters here compared to input
                        (eNumOfDoors)i_VehicleDetails["doors"],
                        (eColor)i_VehicleDetails["Color"],
                        i_Energy,
                        (string)i_VehicleDetails["TireManufacturer"],
                        (float)i_VehicleDetails["TireAirPressure"]);
                    break;
                case eVehicleType.ElectricMotorcycle:
                    break;
                case eVehicleType.GasCar:
                    break;
                case eVehicleType.GasMotorcycle:
                    break;
                case eVehicleType.Truck:
                    break;
            }

            // Set general vehicle properties
            if (vehicle != null)
            {
                vehicle.LicenseID = i_LicenseID;
                vehicle.Model = i_VehicleModel;
            }

            return vehicle;
        }
    }
}

