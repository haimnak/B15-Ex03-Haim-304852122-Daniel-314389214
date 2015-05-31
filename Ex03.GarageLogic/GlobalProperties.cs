namespace Ex03.GarageLogic
{
    /// <summary>
    /// The global properties.
    /// </summary>
    public class GlobalProperties
    {
        /// <summary>
        /// The k_ max air pressure electric car.
        /// </summary>
        public const float k_MaxAirPressureElectricCar = 31;

        /// <summary>
        /// The k_ max air pressure gas car.
        /// </summary>
        public const float k_MaxAirPressureGasCar = 31;

        /// <summary>
        /// The k_ max air pressure electric motor cycle.
        /// </summary>
        public const float k_MaxAirPressureElectricMotorCycle = 31;

        /// <summary>
        /// The k_ max air pressure gas motor cycle.
        /// </summary>
        public const float k_MaxAirPressureGasMotorCycle = 34;

        /// <summary>
        /// The k_ max air pressure truck.
        /// </summary>
        public const float k_MaxAirPressureTruck = 25;

        /// <summary>
        /// The k_ max energy electric car.
        /// </summary>
        public const float k_MaxEnergyElectricCar = (float)2.2;

        /// <summary>
        /// The k_ max energy gas car.
        /// </summary>
        public const float k_MaxEnergyGasCar = 35;

        /// <summary>
        /// The k_ max energy electric motor cycle.
        /// </summary>
        public const float k_MaxEnergyElectricMotorCycle = (float)1.2;

        /// <summary>
        /// The k_ max energy gas motor cycle.
        /// </summary>
        public const float k_MaxEnergyGasMotorCycle = 8;

        /// <summary>
        /// The k_ max energy truck.
        /// </summary>
        public const float k_MaxEnergyTruck = 170;

        /// <summary>
        /// The k_ num of tires car.
        /// </summary>
        public const eNumOfTires k_NumOfTiresCar = eNumOfTires.Four;

        /// <summary>
        /// The k_ num of tires motor cycle.
        /// </summary>
        public const eNumOfTires k_NumOfTiresMotorCycle = eNumOfTires.Two;

        /// <summary>
        /// The k_ num of tires truck.
        /// </summary>
        public const eNumOfTires k_NumOfTiresTruck = eNumOfTires.Sixteen;

        /// <summary>
        /// The k_ fuel type car.
        /// </summary>
        public const eFuelType k_FuelTypeCar = eFuelType.Octan96;

        /// <summary>
        /// The k_ fuel type motor cycle.
        /// </summary>
        public const eFuelType k_FuelTypeMotorCycle = eFuelType.Octan98;

        /// <summary>
        /// The k_ fuel type truck.
        /// </summary>
        public const eFuelType k_FuelTypeTruck = eFuelType.Solar;
    }
}