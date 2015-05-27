// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Electric.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{

    /*
     * Electric vehicle
     */
    public class Electric : Engine
    {
        public float MaxBatteryTime { get; private set; }

        private float m_TimeLeftOnBattery;

        public Electric(float i_TimeLeftOnBattery, float i_MaxBatteryTime)
        {
            this.m_TimeLeftOnBattery = i_TimeLeftOnBattery;
            MaxBatteryTime = i_MaxBatteryTime;
        }

        public float TimeLeftOnBattery
        {
            get
            {
                return this.m_TimeLeftOnBattery;
            }

            set
            {
                float newTimeLeftOnBattery = m_TimeLeftOnBattery += value;
                if (newTimeLeftOnBattery <= MaxBatteryTime)
                {
                    this.m_TimeLeftOnBattery += value;
                    EnergyLevel = m_TimeLeftOnBattery / MaxBatteryTime;
                }
            }
        }


    }
}
