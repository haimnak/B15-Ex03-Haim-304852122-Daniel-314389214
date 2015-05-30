using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class GlobalProperties
    {
        public const float maxAirPressureElectricCar = 31;
        public const float maxAirPressureGasCar = 31;
        public const float maxAirPressureElectricMotorCycle = 31;
        public const float maxAirPressureGasMotorCycle = 34;
        public const float maxAirPressureTruck = 25;

        public const float maxEnergyElectricCar = (float)2.2;
        public const float maxEnergyGasCar = 35;
        public const float maxEnergyElectricMotorCycle = (float)1.2;
        public const float maxEnergyGasMotorCycle = 8;
        public const float maxEnergyTruck = 170;

        public const eNumOfTires numOfTiresCar = eNumOfTires.four;
        public const eNumOfTires numOfTiresMotorCycle = eNumOfTires.two;
        public const eNumOfTires numOfTiresTruck = eNumOfTires.sixteen;

        public const eFuelType fuelTypeCar = eFuelType.Octan96;
        public const eFuelType fuelTypeMotorCycle = eFuelType.Octan98;
    }
}
