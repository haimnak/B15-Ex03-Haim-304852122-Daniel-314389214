// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Electric.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{
    using System;

    /*
     * Electric vehicle
     */
    public class Electric : Engine
    {
        private float m_Charge = 0;

        public Electric(float i_Charge, float i_MaxBatteryTime)
        {
            this.MaxBatteryTime = i_MaxBatteryTime;
            this.Charge = i_Charge;
            
        }

        public float MaxBatteryTime { get; private set; }

        public float Charge
        {
            get
            {
                return this.m_Charge;
            }

            set
            {
                float newTimeLeftOnBattery = this.m_Charge + value;
                if (newTimeLeftOnBattery <= this.MaxBatteryTime)
                {
                    this.m_Charge += value;
                    this.EnergyLevel = this.m_Charge / this.MaxBatteryTime;
                }
                else
                {
                    throw new ValueOutOfRangeException(0, MaxBatteryTime);
                }
            }
        }

        public void ChargeToMax()
        {
            m_Charge = MaxBatteryTime;
        }

    }
}
