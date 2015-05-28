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
        /*
        public Vehicle CreateVehicle(Dictionary<string, object> i_VehicleDetails)
        {
            //ownerInstance(i_VehicleDetails);
            //tiresInstance(i_VehicleDetails);

            eVehicleType vehicleType = (eVehicleType)i_VehicleDetails["VehicleType"];

            switch (vehicleType)
            {
                case eVehicleType.ElectricCar:
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

            //parentInstance(i_VehicleDetails);
        }
        */
        public static Engine CreateEngine(eVehicleType vehicleType, float energy)
        {
            throw new System.NotImplementedException();
        }

        public static List<Tire> CreateTires(eVehicleType vehicleType, string tireManufacturer, float tireMaxPressure)
        {
            throw new System.NotImplementedException();
        }

        public static Vehicle CreateVehicle(
            eVehicleType i_VehicleType,
            string i_VehicleModel,
            string i_LicenseID,
            float i_Energy,
            List<Tire> i_Tires,
            Engine i_Engine,
            Dictionary<string, object> i_VehicleDetails)
        {
            eVehicleType vehicleType = i_VehicleType;

            switch (i_VehicleType)
            {
                case eVehicleType.ElectricCar:
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
        }
    }
}
