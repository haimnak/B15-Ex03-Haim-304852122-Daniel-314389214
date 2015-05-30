using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GlobalProperties
    {
        public const float k_MaxAirPressureElectricCar = 31;
        public const float k_MaxAirPressureGasCar = 31;
        public const float k_MaxAirPressureElectricMotorCycle = 31;
        public const float k_MaxAirPressureGasMotorCycle = 34;
        public const float k_MaxAirPressureTruck = 25;

        public const float k_MaxEnergyElectricCar = (float)2.2;
        public const float k_MaxEnergyGasCar = 35;
        public const float k_MaxEnergyElectricMotorCycle = (float)1.2;
        public const float k_MaxEnergyGasMotorCycle = 8;
        public const float k_MaxEnergyTruck = 170;

        public const eNumOfTires k_NumOfTiresCar = eNumOfTires.Four;
        public const eNumOfTires k_NumOfTiresMotorCycle = eNumOfTires.Two;
        public const eNumOfTires k_NumOfTiresTruck = eNumOfTires.Sixteen;

        public const eFuelType k_FuelTypeCar = eFuelType.Octan96;
        public const eFuelType k_FuelTypeMotorCycle = eFuelType.Octan98;
    }
}
