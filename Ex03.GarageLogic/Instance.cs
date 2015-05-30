using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    using System.Net.NetworkInformation;

    /*
     * Creates object instances
     */

    public class Instance
    {
        public static List<Tire> CreateTires(
            string i_TireManufacturer,
            float i_TireAirPressure,
            float i_MaxAirPressure,
            eNumOfTires i_NumOfTires)
        {
            List<Tire> tireList = new List<Tire>((int)i_NumOfTires);

            for (int i = 0; i < (int)i_NumOfTires; i++)
            {
                Tire tire = new Tire(i_MaxAirPressure, i_TireManufacturer, i_TireAirPressure);
                tireList.Add(tire);
            }

            return tireList;
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
                        (eNumOfDoors)i_VehicleDetails["doors"],
                        (eColor)i_VehicleDetails["Color"]);
                        vehicle.Engine = new Electric(i_Energy, GlobalProperties.k_MaxEnergyElectricCar);
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
                vehicle.Tires = CreateTires(
                    (string)i_VehicleDetails["TireManufacturer"],
                    (float)i_VehicleDetails["TireAirPressure"],
                    GlobalProperties.k_MaxAirPressureElectricCar,
                    GlobalProperties.k_NumOfTiresCar);
                
            }
            
            return vehicle;
        }
    }
}

