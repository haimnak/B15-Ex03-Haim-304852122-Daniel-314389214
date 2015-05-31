namespace Ex03.GarageLogic
{
    public class VehicleInGarage
    {
        public VehicleInGarage(Vehicle i_Vehicle, OwnerDetails i_Owner, eVehicleStatus i_Status)
        {
            this.vehicle = i_Vehicle;
            this.owner = i_Owner;
            this.status = i_Status;
        }

        public Vehicle vehicle { get; set; }

        public OwnerDetails owner { get; set; }

        public eVehicleStatus status { get; set; }

        public override string ToString()
        {
            return string.Format("Owner name: {0}\n{1}\nCurrent Energy: {2}%\n ", owner.Name.ToString(), vehicle.ToString(), vehicle.Energy);
        }
    }
}
