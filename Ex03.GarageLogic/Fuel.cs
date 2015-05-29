// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fuel.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{

    public enum eFuelType
    {
        Solar,
        Octan95,
        Octan96,
        Octan98
    }

    /*
     * Fuel vehicle
     */
    public class Fuel : Engine
    {
        private float m_CurLitersInTank = 0;

        public Fuel(float i_CurLitersInTank, float i_MaxLiters, eFuelType i_FuelType)
        {
            FuelUp(i_FuelType, i_CurLitersInTank);
            EnergyLevel = m_CurLitersInTank / MaxLiters;
            MaxLiters = i_MaxLiters;
            FuelType = i_FuelType;
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
        public void FuelUp(eFuelType i_FuelType, float i_FuelAmount)
        {
            float newFuelAmount = i_FuelAmount + m_CurLitersInTank;

            if (newFuelAmount <= MaxLiters && i_FuelType == FuelType)
            {
                m_CurLitersInTank += i_FuelAmount;
                EnergyLevel = m_CurLitersInTank / MaxLiters;
            }
            // TODO: add exception
        }

        public void FullTank()
        {
            m_CurLitersInTank = MaxLiters;
        }
    }
}
