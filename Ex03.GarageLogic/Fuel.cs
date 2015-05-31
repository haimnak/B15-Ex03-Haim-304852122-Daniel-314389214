namespace Ex03.GarageLogic
{
    using System;

    /// <summary>
    /// The e fuel type.
    /// </summary>
    public enum eFuelType
    {
        /// <summary>
        /// The solar.
        /// </summary>
        Solar = 1, 

        /// <summary>
        /// The octan 95.
        /// </summary>
        Octan95 = 2, 

        /// <summary>
        /// The octan 96.
        /// </summary>
        Octan96 = 3, 

        /// <summary>
        /// The octan 98.
        /// </summary>
        Octan98 = 4
    }

    /*
     * Fuel vehicle
     */

    /// <summary>
    /// The fuel.
    /// </summary>
    public class Fuel : Engine
    {
        /// <summary>
        /// The m_ cur liters in tank.
        /// </summary>
        private float m_CurLitersInTank;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fuel"/> class.
        /// </summary>
        /// <param name="i_CurLitersInTank">
        /// The i_ cur liters in tank.
        /// </param>
        /// <param name="i_MaxLiters">
        /// The i_ max liters.
        /// </param>
        /// <param name="i_FuelType">
        /// The i_ fuel type.
        /// </param>
        public Fuel(float i_CurLitersInTank, float i_MaxLiters, eFuelType i_FuelType)
        {
            MaxLiters = i_MaxLiters;
            FuelType = i_FuelType;
            FuelUp(i_FuelType, i_CurLitersInTank);
            EnergyLevel = m_CurLitersInTank / i_MaxLiters;
        }

        /// <summary>
        /// Gets the max liters.
        /// </summary>
        public float MaxLiters { get; private set; }

        /// <summary>
        /// Gets the fuel type.
        /// </summary>
        public eFuelType FuelType { get; private set; }

        /// <summary>
        /// Gets the cur liters.
        /// </summary>
        public float CurLiters
        {
            get
            {
                return m_CurLitersInTank;
            }
        }

        /*
         * Add fuel to vehicle if the type and amount are valid
         */
        public void FuelUp(eFuelType i_FuelType, float i_FuelAmount)
        {
            float newFuelAmount = i_FuelAmount + m_CurLitersInTank;
            if (newFuelAmount <= MaxLiters)
            {
                if (i_FuelType == FuelType)
                {
                    m_CurLitersInTank += i_FuelAmount;
                    EnergyLevel = m_CurLitersInTank / MaxLiters;
                }
                else
                {
                    throw new ArgumentException("Invalid fuel type");
                }

            }
            else
            {
                throw new ValueOutOfRangeException(0, MaxLiters);
            }

        }
        /// <summary>
        /// The full tank.
        /// </summary>
        public void FullTank()
        {
            m_CurLitersInTank = MaxLiters;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("FuelType: {0}", FuelType);
        }
    }
}
