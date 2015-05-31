namespace Ex03.GarageLogic
{
    /// <summary>
    /// The gas car.
    /// </summary>
    public class GasCar : Car
    {
        /// <summary>
        /// The m_ fuel.
        /// </summary>
        private readonly Fuel m_Fuel;

        /// <summary>
        /// The m_ num of doors.
        /// </summary>
        private readonly eNumOfDoors m_NumOfDoors;

        /// <summary>
        /// The m_ color.
        /// </summary>
        private readonly eColor m_Color;

        /// <summary>
        /// Initializes a new instance of the <see cref="GasCar"/> class.
        /// </summary>
        /// <param name="i_NumOfDoors">
        /// The i_ num of doors.
        /// </param>
        /// <param name="i_Color">
        /// The i_ color.
        /// </param>
        public GasCar(eNumOfDoors i_NumOfDoors, eColor i_Color)
            : base(i_NumOfDoors, i_Color)
        {
            m_Fuel = Engine as Fuel;
            m_NumOfDoors = i_NumOfDoors;
            m_Color = i_Color;
        }

        /// <summary>
        /// Gets the max fuel.
        /// </summary>
        public float MaxFuel
        {
            get
            {
                return m_Fuel.MaxLiters;
            }
        }

        /// <summary>
        /// Gets the fuel type.
        /// </summary>
        public eFuelType FuelType
        {
            get
            {
                return m_Fuel.FuelType;
            }
        }

        /// <summary>
        /// Gets or sets the cur fuel.
        /// </summary>
        public float CurFuel
        {
            get
            {
                return m_Fuel.CurLiters;
            }
        }

        /// <summary>
        /// The fuel up.
        /// </summary>
        /// <param name="i_FuelType">
        /// The i_ fuel type.
        /// </param>
        /// <param name="i_FuelAmount">
        /// The i_ fuel amount.
        /// </param>
        public void FuelUp(eFuelType i_FuelType, float i_FuelAmount)
        {
            m_Fuel.FuelUp(i_FuelType, i_FuelAmount);
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}, Num Of Doors: {1}, Color: {2}", base.ToString(), m_NumOfDoors, m_Color);
        }
    }
}