namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        private readonly Electric m_Electric;
        private readonly eNumOfDoors m_NumOfDoors;
        private readonly eColor m_Color;

        public ElectricCar(
            eNumOfDoors i_NumOfDoors,
            eColor i_Color)
            : base(i_NumOfDoors, i_Color)
        {
             m_Electric = Engine as Electric;
            m_NumOfDoors = i_NumOfDoors;
            m_Color = i_Color;
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
            return string.Format("{0}, Num Of Doors: {1}, Color: {2}", base.ToString(), m_NumOfDoors, m_Color);
        }
    }
}
