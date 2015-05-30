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
        public List<Tire> Tires(
            string i_TireManufacturer,
            float i_TireAirPressure,
            float i_MaxAirPressure,
            int i_NumOfTires)
        {
            List<Tire> tireList = new List<Tire>(i_NumOfTires);

            for (int i = 0; i < i_NumOfTires; i++)
            {
                Tire tire = new Tire(i_MaxAirPressure, i_TireManufacturer, i_TireAirPressure);
                tireList.Add(tire);
            }

            return tireList;
        }
//
//        public Electric Electric(float i_Charge, float i_MaxBatteryTime)
//        {
//            return new Electric(i_Charge, i_MaxBatteryTime);
//        }
//
//        public Fuel Fuel(float i_CurLitersInTank, float i_MaxLiters, eFuelType i_FuelType)
//        {
//            return new Fuel(i_CurLitersInTank, i_MaxLiters, i_FuelType);
//        }
//
//        public OwnerDetails Owner(string i_OwnerName, string i_OwnerNumber)
//        {
//            return new OwnerDetails(i_OwnerName, i_OwnerNumber);
//        }

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
                        (eColor)i_VehicleDetails["Color"]);
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
            /*
            if (vehicle != null)
            {
                vehicle.LicenseID = i_LicenseID;
                vehicle.Model = i_VehicleModel;
                vehicle.Tires = Tires(i_TireManufacturer, )
            }
            */
            return vehicle;
        }
    }
}

