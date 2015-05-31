namespace Ex03.GarageLogic
{
    internal class GasMotorcycle : Motorcycle
    {
        private readonly Fuel m_Fuel;
        private readonly eLicenseType m_LicenseType;
        private readonly int m_Hp;

        public GasMotorcycle(eLicenseType i_LicenseType, int i_HP)
            : base(i_LicenseType, i_HP)
        {
            m_Fuel = Engine as Fuel;
            m_LicenseType = i_LicenseType;
            m_Hp = i_HP;
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

        public void FuelUp(eFuelType i_FuelType, float i_FuelAmount)
        {
            m_Fuel.FuelUp(i_FuelType, i_FuelAmount);
        }

        public override string ToString()
        {
            return string.Format("{0}, LicenseType: {1}, Hp: {2}", base.ToString(), m_LicenseType, m_Hp);
        }
    }
}
