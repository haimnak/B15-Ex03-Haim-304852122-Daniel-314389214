// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectricCar.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{
    using System.Collections.Generic;

    public class ElectricCar : Car
    {
        public ElectricCar(eNumOfDoors i_NumOfDoors, eColor i_Color, float i_BatteryCharge, string i_TireManufacturer, float i_TireAirPressure)
            : base(i_NumOfDoors, i_Color)
        {
            Engine = new Electric(i_BatteryCharge, this.MaxBatteryCharge);

            List<Tire> tireList = new List<Tire>(this.NumOfTires);

            for (int i = 0; i < this.NumOfTires; i++)
            {
                Tire tire = new Tire(this.MaxTirePressure, i_TireManufacturer, i_TireAirPressure);
                tireList.Add(tire);
            }

            this.Tires = tireList;
        }

        public float MaxBatteryCharge
        {
            get
            {
                return 2.2f;
            }
        }

        public override sealed int NumOfTires
        {
            get
            {
                return 4;
            }
        }

        public override sealed float MaxTirePressure
        {
            get
            {
                return 31;
            }
        }

        public override sealed List<Tire> Tires { get; protected set; }

        public override sealed Engine Engine { get; protected set; }
    }
}
