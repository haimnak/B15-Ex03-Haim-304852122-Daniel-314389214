using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class VehicleInGarage
    {
        public Vehicle vehicle{ get; set; }
        public OwnerDetails owner { get; set; }
        public eVehicleStatuses status { get; set; }

        public VehicleInGarage(Vehicle i_Vehicle, OwnerDetails i_Owner, eVehicleStatuses i_Status)
        {
            this.vehicle = i_Vehicle;
            this.owner = i_Owner;
            this.status = status;
        }


        public override string ToString()
        {
            return string.Format("Owner name: {0}\n{1}\nCurrent Energy: {2}% ", owner.Name.ToString(), vehicle.ToString(), vehicle.Energy, vehicle.Engine );
        }


    }
}
