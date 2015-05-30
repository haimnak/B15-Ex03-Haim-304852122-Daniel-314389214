using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricMotorcycle : Motorcycle
    {
        private Electric m_Electric;

        public ElectricMotorcycle(eLicenseType i_LicenseType, int i_HP)
            : base(i_LicenseType, i_HP)
        {
            m_Electric = Engine as Electric;
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
    }
}
