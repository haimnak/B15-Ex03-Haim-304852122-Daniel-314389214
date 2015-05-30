// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GasCar.cs" company="">
//   
// </copyright>
// <summary>
//   The gas car.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{
    using System.Collections.Generic;

    /// <summary>
    /// The gas car.
    /// </summary>
    public class GasCar : Car
    {

        private readonly Fuel m_Fuel;

        public GasCar(
            eNumOfDoors i_NumOfDoors,
            eColor i_Color)
            : base(i_NumOfDoors, i_Color)
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
