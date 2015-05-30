// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectricCar.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{
    using System.Collections.Generic;
    

    public class ElectricCar : Car
    {
        private readonly Electric m_Electric;

        public ElectricCar(
            eNumOfDoors i_NumOfDoors,
            eColor i_Color)
            : base(i_NumOfDoors, i_Color)
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

