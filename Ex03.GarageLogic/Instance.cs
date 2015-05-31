namespace Ex03.GarageLogic
{
    using System.Collections.Generic;
    /*
     * Creates object instances
     */
    
    public class Instance
    {
        private static Vehicle m_Vehicle;

        private static Dictionary<string, object> m_VehicleDetails;

        private static float m_Energy;

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
            m_Vehicle = null;
            m_VehicleDetails = i_VehicleDetails;
            m_Energy = i_Energy;

            switch (i_VehicleType)
            {
                case eVehicleType.ElectricCar:
                    instantiateElectricCar();
                    break;
                case eVehicleType.ElectricMotorcycle:
                    instantiateElectricMotorcycle();
                    break;
                case eVehicleType.GasCar:
                    instantiateGasCar();
                    break;
                case eVehicleType.GasMotorcycle:
                    instantiateGasMotorcycle();
                    break;
                case eVehicleType.Truck:
                    instantiateTruck();
                    break;
            }

            // Set general vehicle properties
            if (m_Vehicle != null)
            {
                m_Vehicle.LicenseID = i_LicenseID;
                m_Vehicle.Model = i_VehicleModel;
            }
            
            return m_Vehicle;
        }

        private static void instantiateTruck()
        {
            m_Vehicle = new Truck(
                        (bool)m_VehicleDetails["dangerousMaterials"],
                        (float)m_VehicleDetails["CurrentCarryingWeight"]);
            m_Vehicle.Engine = new Fuel(m_Energy, GlobalProperties.k_MaxEnergyTruck, GlobalProperties.k_FuelTypeTruck);
            m_Vehicle.Tires = CreateTires(
            (string)m_VehicleDetails["TireManufacturer"],
            (float)m_VehicleDetails["TireAirPressure"],
            GlobalProperties.k_MaxAirPressureTruck,
            GlobalProperties.k_NumOfTiresTruck);
        }

        private static void instantiateGasMotorcycle()
        {
            m_Vehicle = new GasMotorcycle(
                        (eLicenseType)m_VehicleDetails["licenseType"],
                        (int)m_VehicleDetails["engineCapacity"]);
            m_Vehicle.Engine = new Fuel(m_Energy, GlobalProperties.k_MaxEnergyGasMotorCycle, GlobalProperties.k_FuelTypeMotorCycle);
            m_Vehicle.Tires = CreateTires(
            (string)m_VehicleDetails["TireManufacturer"],
            (float)m_VehicleDetails["TireAirPressure"],
            GlobalProperties.k_MaxAirPressureGasMotorCycle,
            GlobalProperties.k_NumOfTiresMotorCycle);
        }

        private static void instantiateGasCar()
        {
            m_Vehicle = new GasCar(
                        (eNumOfDoors)m_VehicleDetails["doors"],
                        (eColor)m_VehicleDetails["Color"]);
            m_Vehicle.Engine = new Fuel(m_Energy, GlobalProperties.k_MaxEnergyGasCar, GlobalProperties.k_FuelTypeCar);
            m_Vehicle.Tires = CreateTires(
            (string)m_VehicleDetails["TireManufacturer"],
            (float)m_VehicleDetails["TireAirPressure"],
            GlobalProperties.k_MaxAirPressureGasCar,
            GlobalProperties.k_NumOfTiresCar);
        }

        private static void instantiateElectricMotorcycle()
        {
            m_Vehicle = new ElectricMotorcycle(
                        (eLicenseType)m_VehicleDetails["licenseType"],
                        (int)m_VehicleDetails["engineCapacity"]);
            m_Vehicle.Engine = new Electric(m_Energy, GlobalProperties.k_MaxEnergyElectricMotorCycle);
            m_Vehicle.Tires = CreateTires(
            (string)m_VehicleDetails["TireManufacturer"],
            (float)m_VehicleDetails["TireAirPressure"],
            GlobalProperties.k_MaxAirPressureElectricMotorCycle,
            GlobalProperties.k_NumOfTiresMotorCycle);
        }

        private static void instantiateElectricCar()
        {
            m_Vehicle = new ElectricCar(
                        (eNumOfDoors)m_VehicleDetails["doors"],
                        (eColor)m_VehicleDetails["Color"]);
            m_Vehicle.Engine = new Electric(m_Energy, GlobalProperties.k_MaxEnergyElectricCar);
            m_Vehicle.Tires = CreateTires(
            (string)m_VehicleDetails["TireManufacturer"],
            (float)m_VehicleDetails["TireAirPressure"],
            GlobalProperties.k_MaxAirPressureElectricCar,
            GlobalProperties.k_NumOfTiresCar);
        }
    }
}
