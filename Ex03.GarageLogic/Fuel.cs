// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fuel.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace Ex03.GarageLogic
{

    public enum eFuelType
    {
        Solar = 1,
        Octan95 = 2,
        Octan96 = 3,
        Octan98 = 4
    }

    /*
     * Fuel vehicle
     */
    public class Fuel : Engine
    {
        private float m_CurLitersInTank = 0;

        public Fuel(float i_CurLitersInTank, float i_MaxLiters, eFuelType i_FuelType)
        {
            MaxLiters = i_MaxLiters;
            FuelType = i_FuelType;
            FuelUp(i_FuelType, i_CurLitersInTank);
            EnergyLevel = m_CurLitersInTank / i_MaxLiters;
            
        }

        public float MaxLiters { get; private set; }
        public eFuelType FuelType { get; private set; }
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

        public bool FuelUp(eFuelType i_FuelType, float i_FuelAmount)
        {
            bool success = false;
            float newFuelAmount = i_FuelAmount + m_CurLitersInTank;
            if (newFuelAmount <= MaxLiters)
            {
                if (i_FuelType == FuelType)
                {
                    m_CurLitersInTank += i_FuelAmount;
                    EnergyLevel = m_CurLitersInTank/MaxLiters;
                    success = true;
                }
                else
                {
                    throw new ArgumentException("Invalid fuel type");
                }
                
            }
            else
            {
                throw  new ValueOutOfRangeException(0, MaxLiters);
            }
            return success;
        }

        public void FullTank()
        {
            m_CurLitersInTank = MaxLiters;
        }

        public override string ToString()
        {

            return string.Format("FuelType: {0}", FuelType);

            //return string.Format("MaxLiters: {0}, FuelType: {1}, CurLiters: {2}", this.MaxLiters, this.FuelType, this.CurLiters);

        }
    }
}
