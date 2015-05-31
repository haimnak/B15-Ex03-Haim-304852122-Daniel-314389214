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
        private readonly bool m_DangerousMaterials;
        private readonly float m_CurrentCarryingWeight;

        public Truck(
            bool i_DangerousMaterials,
            float i_CurrentCarryingWeight)
        {
            DangerousMaterials = i_DangerousMaterials;
            CurrentCarryingWeight = i_CurrentCarryingWeight;
            m_Fuel = Engine as Fuel;
            m_DangerousMaterials = i_DangerousMaterials;
            m_CurrentCarryingWeight = i_CurrentCarryingWeight;
        }

        public float CurrentCarryingWeight { get; private set; }

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

        public override string ToString()
        {
            return string.Format("{0}, DangerousMaterials: {1}, CurrentCarryingWeight: {2}", base.ToString(), m_DangerousMaterials, m_CurrentCarryingWeight);
        }
    }
}
