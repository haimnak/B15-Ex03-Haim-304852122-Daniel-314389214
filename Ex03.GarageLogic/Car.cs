using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum eColor
    {
        Green,
        Black,
        White,
        Red
    }

    public enum eNumOfDoors
    {
        Two,
        Three,
        Four,
        Five
    }

    public class Car : Vehicle
    {
        /*
         * Constructs a vehicle
         */
        public Car(string i_LicenseID, string i_Model)
        {

        }

        public eNumOfDoors NumOfDoors { get; protected set; }

        public eColor Color { get; protected set; }
    }
}
