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
        public GasCar(eNumOfDoors i_NumOfDoors, eColor i_Color, float i_CurFuel, string i_TireManufacturer, float i_TireAirPressure)
            : base(i_NumOfDoors, i_Color)
        {
            this.CurFuel = i_CurFuel;
            Engine = new Fuel(this.CurFuel, this.MaxFuel, this.FuelType);

            List<Tire> tireList = new List<Tire>(this.NumOfTires);

            for (int i = 0; i < this.NumOfTires; i++)
            {
                Tire tire = new Tire(this.MaxTirePressure, i_TireManufacturer, i_TireAirPressure);
                tireList.Add(tire);
            }

            this.Tires = tireList;
        }

        /// <summary>
        /// Gets the num of tires.
        /// </summary>
        public override sealed int NumOfTires
        {
            get
            {
                return 4;
            }
        }

        /// <summary>
        /// Gets the max tire pressure.
        /// </summary>
        public override sealed float MaxTirePressure
        {
            get
            {
                return 31;
            }
        }

        /// <summary>
        /// Gets the max fuel.
        /// </summary>
        public float MaxFuel 
        { 
            get
            {
                return 35;
            }
        }

        /// <summary>
        /// Gets the fuel type.
        /// </summary>
        public eFuelType FuelType
        {
            get
            {
                return eFuelType.Octan96;
            }
        }

        /// <summary>
        /// Gets or sets the cur fuel.
        /// </summary>
        public float CurFuel { get; set; }

        /// <summary>
        /// Gets or sets the tires.
        /// </summary>
        public override sealed List<Tire> Tires { get; protected set; }

        /// <summary>
        /// Gets or sets the engine.
        /// </summary>
        public override sealed Engine Engine { get; protected set; }
    }
}
