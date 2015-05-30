using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;

namespace Ex03.GarageManagementSystem.ConsoleUI
{

    /*
    * Main menu options
    */
    public enum eMainMenu
    {
        VehicleToGarage = 1,
        LicenseNumberList = 2,
        UpdateStatus = 3,
        InflateTires = 4,
        RefuelVehicle = 5,
        RechargeVehicle = 6,
        GetData = 7,
        Exit = 0
    }

    /*
     * UI class calls the logic
     */
    public class UI
    {
        /*
         * Starts the garage program
         */
        private Garage m_Garage;

        public UI()
        {
            m_Garage = new Garage();
            OpenGarage();
        }

        /*
         * Opens the garage
         */
        private void OpenGarage()
        {
            MainMenu();
        }

        /*
         * Garage main menu
         */
        private void MainMenu()
        {
            eMainMenu menuSelection = this.ShowMainMenu();

            while (menuSelection != eMainMenu.Exit)
            {
                switch (menuSelection)
                {
                    case eMainMenu.VehicleToGarage:
                        AddVehicle();
                        break;
                    case eMainMenu.LicenseNumberList:
                        GetFilteredList();
                        break;
                    case eMainMenu.UpdateStatus:
                        UpdateVehicleStatus();
                        break;
                    case eMainMenu.InflateTires:
                        InflateTires();
                        break;
                    case eMainMenu.RefuelVehicle:
                        RefuelVehicle();
                        break;
                    case eMainMenu.RechargeVehicle:
                        RechargeVehicle();
                        break;
                    case eMainMenu.GetData:
                        GetData();
                        break;
                    case eMainMenu.Exit:
                        break;
                }
            }
        }

        private void GetData()
        {
            string licenseID = View.GeneralScan("License:");
            bool carInGarage = m_Garage.thisCarInTheGarage(licenseID);

            if (carInGarage)
            {
                Console.WriteLine(m_Garage.getData(licenseID));
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }

            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        private void RefuelVehicle()
        {
            string licenseID = View.GeneralScan("License:");
            bool carInGarage = m_Garage.thisCarInTheGarage(licenseID);
            if (carInGarage)
            {
                eFuelType fuelType = (eFuelType)View.MenuScan(@"Choose fuelType:
 1. Solar,
 2. Octan95,
 3. Octan96,
 4. Octan98", 4);

                float amount = View.NumberScan("Inserts amount:");
                m_Garage.refuelVehicle(licenseID, fuelType, amount);
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        private void RechargeVehicle()
        {
            string licenseID = View.GeneralScan("License:");
            bool carInGarage = m_Garage.thisCarInTheGarage(licenseID);
            if (carInGarage)
            {
                float amount = View.NumberScan("Inserts amount:");

                while (!m_Garage.RechargeVehicle(licenseID, amount))
                {
                    View.PrintInvalidInput("Too much energy!");
                    amount = View.NumberScan("Inserts amount:");
                    m_Garage.RechargeVehicle(licenseID, amount);
                }

                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        private void InflateTires()
        {
            string licenseID = View.GeneralScan("License:");
            bool carInGarage = m_Garage.thisCarInTheGarage(licenseID);

            if (carInGarage)
            {
                m_Garage.InflateTiresToMax(licenseID);
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        private void UpdateVehicleStatus()
        {
            string licenseID = View.GeneralScan("License:");
            bool carInGarage = m_Garage.thisCarInTheGarage(licenseID);

            if (carInGarage)
            {
                eVehicleStatuses statusToChange = (eVehicleStatuses)View.MenuScan(@"Car status:

1. UnderRepair
2. Repaired
3. Paid", 3);
                m_Garage.updateCarStatus(licenseID, statusToChange);
                Console.WriteLine("Car status had changed");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else
            {
                throw new ArgumentException("Car not in the garage");
            }
        }

        /*
         * Show all licenses ID in the garage with an option to filter them by status 
         */
        private void GetFilteredList()
        {
            int choose = View.MenuScan(@"Show licenses ID by Status?
1. Yes
2. NO", 2);

            if (choose == 1)
            {
                eVehicleStatuses status = (eVehicleStatuses)View.MenuScan(@"Car status:

1. UnderRepair
2. Repaired
3. Paid", 3);
                List<string> licensesID = m_Garage.getLicensesIDInTheGarage(status);
                printList(licensesID);
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
            else
            {
                List<string> licensesIDUnderRepair= new List<string>();
                licensesIDUnderRepair = m_Garage.getLicensesIDInTheGarage(eVehicleStatuses.UnderRepair);
                List<string> licensesIDRepaired = new List<string>();
                licensesIDRepaired = m_Garage.getLicensesIDInTheGarage(eVehicleStatuses.Repaired);
                List<string> licensesIDPaid = new List<string>();
                licensesIDPaid = m_Garage.getLicensesIDInTheGarage(eVehicleStatuses.Paid);
                printList(licensesIDUnderRepair);
                printList(licensesIDRepaired);
                printList(licensesIDPaid);
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
        }

        private void printList(List<string> strings)
        {
            int counter = 0;
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings[counter]);
                counter++;
            }
           
        }

        private void AddVehicle()
        {
            // get licenseID
            string licenseID = View.GeneralScan("License:");

            /*
             *  Check if the this car (licenseID) is already in the garage - update status "in reapir" 
             *  else add a new car to the gargae 
             */

         
            if (m_Garage.thisCarInTheGarage(licenseID))
            {
                Console.WriteLine("The car is moving to fix");

                     
                m_Garage.updateCarStatus(licenseID, eVehicleStatuses.UnderRepair);
                Console.ReadLine();
            }
            else
            {
                
                OwnerDetails owner = new OwnerDetails(View.GeneralScan("Owner Name:"), View.NumberScan("Owner Number:").ToString());


                eVehicleType vehicleType = (eVehicleType)View.MenuScan(@"Vehicle Type:

1. Electric Car
2. Gas Car
3. Electric Motorcycle
4. Gas Motorcycle
5. Truck", 5);
                Dictionary<string, object> details = new Dictionary<string, object>();
                string vehicleModel = View.GeneralScan("Vehicle Model:");
                float energy = View.NumberScan("Insert energy level:");

                string tireManufacturer = View.GeneralScan("Tire Manufacturer:");
                float tireAirPressure = View.NumberScan("Tire Air Pressure:");

                details.Add("TireManufacturer", tireManufacturer);
                details.Add("TireAirPressure", tireAirPressure);

                switch (vehicleType)
                {
                    case eVehicleType.ElectricCar:
                    case eVehicleType.GasCar:
                        eColor color = (eColor)View.MenuScan(@"Choose car's color: 
1. Green
2. Black
3. White
4. Red", 4);
                        details.Add("Color", color);
                        eNumOfDoors doors = (eNumOfDoors)View.MenuScan(@"Choose car's number of doors:
1. Two
2. Three
3. Four
4. Five", 4);
                        details.Add("doors", doors);
                        break;

                    case eVehicleType.ElectricMotorcycle:
                    case eVehicleType.GasMotorcycle:
                        eLicenseType licenseType = (eLicenseType)View.MenuScan(@"Choose mtorcycle's licenseType:
1. A
2. A2
3. AB
4. B1", 4);
                        details.Add("licenseType", licenseType);

                        // TODO: add NumberScan int Type in View class
//                        float engineCapacity = View.NumberScan("Insert engine Capacity:");
//                        if (engineCapacity != Math.Floor((engineCapacity)))
//                        {
//                            System.Console.WriteLine("invalid input");
//                            View.NumberScan("Insert engine Capacity:");
//                        }
//                        else
//                        {
//                            details.Add("engineCapacity", engineCapacity);
//                            break;
//                        }
                        break;


                    case eVehicleType.Truck:

                        // TODO: add MenuScan bool Type in View class? chagne dangerousMaterials to enum in Truck class?
                        int choose = View.MenuScan(@"Contains dangerous materials :
1. Yes
2. NO", 2);
                        bool dangerousMaterials;
                        // TODO: Switch to Enum
                        if (choose == 1)
                        {
                            dangerousMaterials = true;
                        }
                        else
                        {
                            dangerousMaterials = false;
                        }
                        details.Add("dangerousMaterials", dangerousMaterials);
                        float CurrentCarryingWeight = View.NumberScan("Insert Current Carrying Weight:");
                        details.Add("CurrentCarryingWeight", CurrentCarryingWeight);
                        break;
                }

                Vehicle vehicle = Instance.CreateVehicle(
                    vehicleType,
                    vehicleModel,
                    licenseID,
                    energy,
                    details);

                // upadate status in repair in garage class
                //TODO: Use OwnerDetails obj here
                m_Garage.InsertVehicle(owner.Name, owner.Number, vehicle);
                Console.WriteLine("The new vehicle was added to the garage");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
        }

        /*
         * Show main menu and get selection
         */
        private eMainMenu ShowMainMenu()
        {
            string mainMenuScreen = @"Garage System

1. Enter Vehicle to Garage
2. Get Checked-in Vehicle License Number List
3. Update Vehicle Status
4. Inflate Vehicle Tires
5. Fuel Vehicle
6. Charge Vehicle
7. Get Vehicle Data

Press 9 at any time to return to the main menu, or 0 to exit.";
            return (eMainMenu)View.MenuScan(mainMenuScreen, 7);
        }
    }


}
