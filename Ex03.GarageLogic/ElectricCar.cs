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
        private readonly Electric m_Electric;

        public ElectricCar(
            eNumOfDoors i_NumOfDoors,
            eColor i_Color,
            float i_BatteryCharge,
            string i_TireManufacturer,
            float i_TireAirPressure)
            : base(i_NumOfDoors, i_Color)
        {
            this.MaxTirePressure = 31;
            this.NumOfTires = 4;
            this.m_Electric = new Electric(i_BatteryCharge, 2.2f);
            this.Engine = this.m_Electric;

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
                return this.m_Electric.MaxBatteryTime;
            }
        }

        public float Charge
        {
            get
            {
                return this.m_Electric != null ? this.m_Electric.Charge : 0;
            }

            set
            {
                if (this.m_Electric != null)
                {
                    this.m_Electric.Charge = value;
                }
            }
        }

        public void ChargeToMax()
        {
            if (this.m_Electric != null)
            {
                this.m_Electric.ChargeToMax();
            }
        }
    }
}

