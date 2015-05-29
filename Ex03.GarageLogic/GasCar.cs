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

        /// <summary>
        /// Initializes a new instance of the <see cref="GasCar"/> class.
        /// </summary>
        /// <param name="i_NumOfDoors">
        /// The i_ num of doors.
        /// </param>
        /// <param name="i_Color">
        /// The i_ color.
        /// </param>
        /// <param name="i_CurFuel">
        /// The i_ cur fuel.
        /// </param>
        /// <param name="i_TireManufacturer">
        /// The i_ tire manufacturer.
        /// </param>
        /// <param name="i_TireAirPressure">
        /// The i_ tire air pressure.
        /// </param>
        public GasCar(
            eNumOfDoors i_NumOfDoors,
            eColor i_Color,
            float i_CurFuel,
            string i_TireManufacturer,
            float i_TireAirPressure)
            : base(i_NumOfDoors, i_Color)
        {
            this.Engine = new Fuel(i_CurFuel, 35, eFuelType.Octan96);
            List<Tire> tireList = new List<Tire>(this.NumOfTires);

            for (int i = 0; i < this.NumOfTires; i++)
            {
                Tire tire = new Tire(31, i_TireManufacturer, i_TireAirPressure);
                tireList.Add(tire);
            }

            this.Tires = tireList;
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
