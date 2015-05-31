namespace Ex03.GarageLogic
{
    /// <summary>
    /// The truck.
    /// </summary>
    public class Truck : Vehicle
    {
        /// <summary>
        /// The m_ fuel.
        /// </summary>
        private readonly Fuel m_Fuel;

        /// <summary>
        /// The m_ dangerous materials.
        /// </summary>
        private readonly bool m_DangerousMaterials;

        /// <summary>
        /// The m_ current carrying weight.
        /// </summary>
        private readonly float m_CurrentCarryingWeight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Truck"/> class.
        /// </summary>
        /// <param name="i_DangerousMaterials">
        /// The i_ dangerous materials.
        /// </param>
        /// <param name="i_CurrentCarryingWeight">
        /// The i_ current carrying weight.
        /// </param>
        public Truck(bool i_DangerousMaterials, float i_CurrentCarryingWeight)
        {
            DangerousMaterials = i_DangerousMaterials;
            CurrentCarryingWeight = i_CurrentCarryingWeight;
            m_Fuel = Engine as Fuel;
            m_DangerousMaterials = i_DangerousMaterials;
            m_CurrentCarryingWeight = i_CurrentCarryingWeight;
        }

        /// <summary>
        /// Gets the current carrying weight.
        /// </summary>
        public float CurrentCarryingWeight { get; private set; }

        /// <summary>
        /// Gets a value indicating whether dangerous materials.
        /// </summary>
        public bool DangerousMaterials { get; private set; }

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
        /// Gets the cur fuel.
        /// </summary>
        public float CurFuel
        {
            get
            {
                return m_Fuel.CurLiters;
            }
        }

        /*
         * Fuel up the truck
         */

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
            return string.Format(
                "{0}, DangerousMaterials: {1}, CurrentCarryingWeight: {2}", 
                base.ToString(), 
                m_DangerousMaterials, 
                m_CurrentCarryingWeight);
        }
    }
}