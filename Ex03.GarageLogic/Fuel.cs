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
        public Fuel(float i_CurLitersInTank, float i_MaxLiters, eFuelType i_FuelType)
        {
            this.m_CurLitersInTank = i_CurLitersInTank;
            EnergyLevel = m_CurLitersInTank / MaxLiters;
            MaxLiters = i_MaxLiters;
            FuelType = i_FuelType;
        }

        public float MaxLiters { get; private set; }

        public eFuelType FuelType { get; private set; }

        private float m_CurLitersInTank;

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
    }
}
