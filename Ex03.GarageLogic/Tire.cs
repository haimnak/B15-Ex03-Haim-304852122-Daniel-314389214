namespace Ex03.GarageLogic
{
    /// <summary>
    /// The e num of tires.
    /// </summary>
    public enum eNumOfTires
    {
        /// <summary>
        /// The two.
        /// </summary>
        Two = 2, 

        /// <summary>
        /// The four.
        /// </summary>
        Four = 4, 

        /// <summary>
        /// The sixteen.
        /// </summary>
        Sixteen = 16
    }

    /*
        * Holds the tire properties
        */

    /// <summary>
    /// The tire.
    /// </summary>
    public class Tire
    {
        /// <summary>
        /// The r_ max pressure.
        /// </summary>
        private readonly float r_MaxPressure;

        /// <summary>
        /// The r_ manufacturer.
        /// </summary>
        private readonly string r_Manufacturer;

        /// <summary>
        /// The m_ air pressure.
        /// </summary>
        private float m_AirPressure;

        /*
         * Tire constructor
         */

        /// <summary>
        /// Initializes a new instance of the <see cref="Tire"/> class.
        /// </summary>
        /// <param name="i_MaxPressure">
        /// The i_ max pressure.
        /// </param>
        /// <param name="i_Manufacturer">
        /// The i_ manufacturer.
        /// </param>
        /// <param name="i_AirPressure">
        /// The i_ air pressure.
        /// </param>
        public Tire(float i_MaxPressure, string i_Manufacturer, float i_AirPressure)
        {
            this.r_MaxPressure = i_MaxPressure;
            this.r_Manufacturer = i_Manufacturer;
            this.m_AirPressure = i_AirPressure;
        }

        /* 
         * Get manufacturer name
         */

        /// <summary>
        /// Gets the manufacturer.
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return r_Manufacturer;
            }
        }

        /*
         * Get/Set tire air pressure
         */

        /// <summary>
        /// Gets or sets the air pressure.
        /// </summary>
        public float AirPressure
        {
            get
            {
                return m_AirPressure;
            }

            set
            {
                float pumpedPressure = m_AirPressure + value;

                // Check we're adding a valid amount of pressure
                if (pumpedPressure < MaxPressure)
                {
                    m_AirPressure += value;
                }
            }
        }

        /* 
         * Get tire max air pressure
         */

        /// <summary>
        /// Gets the max pressure.
        /// </summary>
        public float MaxPressure
        {
            get
            {
                return r_MaxPressure;
            }
        }

        /// <summary>
        /// The inflate to max.
        /// </summary>
        public void inflateToMax()
        {
            m_AirPressure = r_MaxPressure;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
@"Manufacturer: {0}
Current Air Pressure: {1}
Max Pressure: {2}",
                  Manufacturer,
                  AirPressure,
                  MaxPressure);
        }
    }
}