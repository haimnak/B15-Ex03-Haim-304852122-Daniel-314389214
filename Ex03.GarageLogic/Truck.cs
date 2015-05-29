using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private readonly bool r_DangerousMaterials;

        private readonly float r_CurrentCarryingWeight;

        public Fuel Fuel { get; set; }

        protected Truck(bool i_DangerousMaterials, float i_CurrentCarryingWeight, float i_CurLitersInTank)
            : base()
        {
            this.r_DangerousMaterials = i_DangerousMaterials;
            this.r_CurrentCarryingWeight = i_CurrentCarryingWeight;
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
    }
}
