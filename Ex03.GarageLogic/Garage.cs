namespace Ex03.GarageLogic
{
    using System;
    using System.Collections.Generic;

    /*
        * Vehicle satus
        */

    /// <summary>
    /// The e vehicle statuses.
    /// </summary>
    public enum eVehicleStatus
    {
        /// <summary>
        /// The under repair.
        /// </summary>
        UnderRepair = 1, 

        /// <summary>
        /// The repaired.
        /// </summary>
        Repaired = 2, 

        /// <summary>
        /// The paid.
        /// </summary>
        Paid = 3
    }

    /*
     * A new vehicle arrives at the garage: 
     * Create a vehicle instance and add it to the list
     */

    /// <summary>
    /// The garage.
    /// </summary>
    public class Garage
    {
        /// <summary>
        /// The all cars in the garage.
        /// </summary>
        public Dictionary<string, VehicleInGarage> AllCarsInTheGarage = new Dictionary<string, VehicleInGarage>();

        /// <summary>
        /// The this car in the garage.
        /// </summary>
        /// <param name="i_licenseId">
        /// The i_license id.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool thisCarInTheGarage(string i_licenseId)
        {
            bool inGarage = AllCarsInTheGarage.ContainsKey(i_licenseId);

            return inGarage;
        }

        public string getData(string i_licenseId)
        {
            if (thisCarInTheGarage(i_licenseId))
            {
                VehicleInGarage vehicleInGarage;
                AllCarsInTheGarage.TryGetValue(i_licenseId, out vehicleInGarage);
                if (vehicleInGarage != null)
                {
                    return vehicleInGarage.ToString();
                }
            }
            else
            {
                throw new ArgumentException("car not in the garage");
            }

            return null;
        }


public void refuelVehicle(string licenseId, eFuelType fuelType, float amount)
        {
            
            if (thisCarInTheGarage(licenseId))
            {
                VehicleInGarage vehicleInGarage;
                AllCarsInTheGarage.TryGetValue(licenseId, out vehicleInGarage);
                Fuel fuelEngine = vehicleInGarage.vehicle.Engine as Fuel;
                if (fuelEngine != null)
                {
                    try
                    {
                        fuelEngine.FuelUp(fuelType, amount);
                    }
                    catch (Exception exception)
                    {

                        throw new ArgumentException(exception.Message);
                    }

                }
                else
                {
                    throw new ArgumentException("Impossible fuel this vechicle type");
                }

            }
            else
            {
                throw new ArgumentException("car not in the garage");
            }
            
        }

        public bool RechargeVehicle(string licenseId, float amount)
        {
            bool success = false;
            if (thisCarInTheGarage(licenseId))
            {
                VehicleInGarage vehicleInGarage;
                AllCarsInTheGarage.TryGetValue(licenseId, out vehicleInGarage);
                if (vehicleInGarage != null)
                {
                    Electric electricEngine = vehicleInGarage.vehicle.Engine as Electric;
                    if (electricEngine != null)
                    {
                        if (electricEngine.Charge + amount <= electricEngine.MaxBatteryTime)
                        {
                            electricEngine.Charge = amount;
                            success = true;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Impossible charge this vechicle type");
                    }
                }
            }
            else
            {
                throw new ArgumentException("car not in the garage");
            }

            return success;
        }

        public void InflateTiresToMax(string licenseId)
        {
            if (thisCarInTheGarage(licenseId))
            {
                VehicleInGarage vehicleInGarage;
                bool success = AllCarsInTheGarage.TryGetValue(licenseId, out vehicleInGarage);

                // Inflate each tire to maximum
                if (success)
                {
                    foreach (Tire tire in vehicleInGarage.vehicle.Tires)
                    {
                        tire.inflateToMax();
                    }
                }
                else
                {
                    throw new ArgumentException("No vehicle for that ID");
                }
            }
            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        public void updateCarStatus(string licenseId, eVehicleStatus statusToChange)
        {
            if (thisCarInTheGarage(licenseId))
            {
                VehicleInGarage vehicleInGarage;
                AllCarsInTheGarage.TryGetValue(licenseId, out vehicleInGarage);
                if (vehicleInGarage != null)
                {
                    vehicleInGarage.status = statusToChange;
                }
            }
            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        public List<string> getLicensesIDInTheGarage(eVehicleStatus status)
        {
            List<string> licenses = new List<string>();
            foreach (KeyValuePair<string, VehicleInGarage> vehicleInGarage in AllCarsInTheGarage)
            {
                if (vehicleInGarage.Value.status == status)
                {
                    licenses.Add(vehicleInGarage.Key);
                }
            }

            return licenses;
        }

        public void InsertVehicle(string name, string phoneNumber, Vehicle i_vehicle)
        {
            OwnerDetails owner = new OwnerDetails(name, phoneNumber);
            VehicleInGarage vehicle = new VehicleInGarage(i_vehicle, owner, eVehicleStatus.UnderRepair);
            AllCarsInTheGarage.Add(i_vehicle.LicenseID, vehicle);
        }
    }
}
