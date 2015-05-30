using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private readonly Fuel m_Fuel;

        public Truck(
            bool i_DangerousMaterials,
            float i_CurrentCarryingWeight,
            float i_CurLitersInTank,
            string i_TireManufacturer,
            float i_TireAirPressure)
        {
            DangerousMaterials = i_DangerousMaterials;
            CurrentCarryingWeight = i_CurrentCarryingWeight;
            NumOfTires = 16;

            m_Fuel = new Fuel(i_CurLitersInTank, 170, eFuelType.Solar);
            this.Engine = m_Fuel;
            List<Tire> tireList = new List<Tire>(this.NumOfTires);

            for (int i = 0; i < this.NumOfTires; i++)
            {
                Tire tire = new Tire(31, i_TireManufacturer, i_TireAirPressure);
                tireList.Add(tire);
            }

            this.Tires = tireList;
        }

        public float CurrentCarryingWeight { get; set; }

        public bool DangerousMaterials { get; private set; }

        public float MaxFuel
        {
            get
            {
                return m_Fuel.MaxLiters;
            } 
        }

        public float CurFuel
        {
            get
            {
                return m_Fuel.CurLiters;
            }
        }

        /*
         * Fuel up the truck
         */
        public void FuelUp(eFuelType i_FuelType, float i_FuelAmount)
        {
            m_Fuel.FuelUp(i_FuelType, i_FuelAmount);
        }
    }
}
