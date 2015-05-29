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
        private Electric m_Electric;

        public ElectricCar(eNumOfDoors i_NumOfDoors, eColor i_Color, float i_BatteryCharge, string i_TireManufacturer, float i_TireAirPressure)
            : base(i_NumOfDoors, i_Color)
        {
            this.m_Electric = new Electric(i_BatteryCharge, this.MaxBatteryCharge);
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

        public float Charge
        {
            get
            {
                return this.m_Electric != null ? this.m_Electric.TimeLeftOnBattery : 0;
            }

            set
            {
                if (this.m_Electric != null)
                {
                    float newCharge = this.Charge + value;

                    if (newCharge <= this.MaxBatteryCharge)
                    {
                        this.Charge += value;
                        this.Energy = this.Charge / this.MaxBatteryCharge;
                    }
                }
            }
        }

        public void ChargeToMax()
        {
            if (this.m_Electric != null)
            {
                this.m_Electric.TimeLeftOnBattery = this.MaxBatteryCharge;
            }
        }
    }
}

