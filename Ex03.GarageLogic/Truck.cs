using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private const int k_NumOfWheels = 16;

        private readonly bool r_DangerousMaterials;

        private readonly float r_CurrentCarryingWeight;

        public Fuel Fuel { get; set; }

        protected Truck(bool i_DangerousMaterials, float i_CurrentCarryingWeight, float i_CurLitersInTank)
            : base()
        {
            this.r_DangerousMaterials = i_DangerousMaterials;
            this.r_CurrentCarryingWeight = i_CurrentCarryingWeight;
        }

        // TODO
        public Truck(string i_VehicleType, string i_LicenseId, float i_EnergyPercentage, List<Tire> i_Tires, bool r_DangerousMaterials, float r_CurrentCarryingWeight, Fuel m_Fuel)
        {
            this.r_DangerousMaterials = r_DangerousMaterials;
            this.r_CurrentCarryingWeight = r_CurrentCarryingWeight;
        }

        /*
         * Fuel up the truck
         */
        public void FuelUp(float i_FuelAmount)
        {
            Fuel.FuelUp(eFuelType.Solar, i_FuelAmount);
        }

        public override int NumOfTires
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override float MaxTirePressure
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override List<Tire> Tires { get; protected set; }

        public override Engine Engine { get; protected set; }
    }
}
