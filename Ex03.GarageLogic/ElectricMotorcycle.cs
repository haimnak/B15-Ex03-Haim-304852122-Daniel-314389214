namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : Motorcycle
    {
        private readonly Electric m_Electric;
        private readonly eLicenseType m_LicenseType;
        private readonly int m_Hp;

        public ElectricMotorcycle(eLicenseType i_LicenseType, int i_HP)
            : base(i_LicenseType, i_HP)
        {
            m_Electric = Engine as Electric;
            m_LicenseType = i_LicenseType;
            m_Hp = i_HP;
        }

        public float MaxBatteryCharge
        {
            get
            {
                return m_Electric.MaxBatteryTime;
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

        public override string ToString()
        {
            return string.Format("{0}, LicenseType: {1}, Hp: {2}", base.ToString(), m_LicenseType, m_Hp);
        }
    }
}
