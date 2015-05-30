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
            m_Fuel = Engine as Fuel;
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
    }
}
