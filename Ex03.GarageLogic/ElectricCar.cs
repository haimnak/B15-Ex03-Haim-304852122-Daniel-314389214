using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        public Electric Engine { get; private set; }

        public ElectricCar(string i_LicenseID, string i_Model, Electric i_Engine)
            : base(i_LicenseID, i_Model)
        {
            Engine = i_Engine;

        }
    }
}
