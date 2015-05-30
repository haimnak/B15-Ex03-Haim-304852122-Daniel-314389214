using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class GasMotorcycle : Motorcycle
    {
        private readonly Fuel m_Fuel;

        public GasMotorcycle(eLicenseType i_LicenseType, int i_HP)
            : base(i_LicenseType, i_HP)
        {
        }
    }
}
