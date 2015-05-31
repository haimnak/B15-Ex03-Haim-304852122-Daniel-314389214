namespace Ex03.GarageLogic
{
    /*
     * Electric vehicle
     */

    /// <summary>
    /// The electric.
    /// </summary>
    public class Electric : Engine
    {
        /// <summary>
        /// The m_ charge.
        /// </summary>
        private float m_Charge = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Electric"/> class.
        /// </summary>
        /// <param name="i_Charge">
        /// The i_ charge.
        /// </param>
        /// <param name="i_MaxBatteryTime">
        /// The i_ max battery time.
        /// </param>
        public Electric(float i_Charge, float i_MaxBatteryTime)
        {
            this.MaxBatteryTime = i_MaxBatteryTime;
            this.Charge = i_Charge;
        }

        /// <summary>
        /// Gets the max battery time.
        /// </summary>
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

        /// <summary>
        /// The charge to max.
        /// </summary>
        public void ChargeToMax()
        {
            m_Charge = MaxBatteryTime;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return "Electric engine";
        }
    }
}
