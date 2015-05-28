using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class VehicleInGarage
    {
        public Vehicle vehicle;
        public OwnerDetails owner;
        public eVehicleStatuses status;

        public VehicleInGarage(Vehicle i_vehicle, OwnerDetails i_owner, eVehicleStatuses i_status)
        {
            this.vehicle = i_vehicle;
            this.owner = i_owner;
            this.status = i_status;
        }


//        public override string ToString()
//        {
//            return string.Format("LicenseID: {0},Model Type: {1},Owner name: {2},Status in the garage: {3}," +
//                                 "Tires details: {4}, Current energy: {5}, Gas type: {6}",this.vehicle.LicenseID,
//                                 this.vehicle.Model, this.owner.Name, this.status, tiresDetails(this.vehicle.Tires), this.vehicle.Tires, this.vehicle.currentEnergy,
//                                 this.vehicle.Engine);
//        }

        public StringBuilder tiresDetails(List<Tire> tires)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Tire tire in tires)
            {
                sb.Append(tire.ToString());
            }
            return sb;
        }
    }
}
