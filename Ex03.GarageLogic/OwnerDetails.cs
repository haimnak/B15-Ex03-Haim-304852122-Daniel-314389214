using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    /*
        * Contains owner details and vehicle status
        */
    public class OwnerDetails
    {
        public string Name { get; private set; }

        public string Number { get; private set; }

        public OwnerDetails(string i_Name, string i_Number)
        {
            this.Name = i_Name;
            this.Number = i_Number;
        }

        public override string ToString()
        {
            return string.Format("Owner Name: {0}, Number: {1}", this.Name, this.Number);
        }
    }
}
