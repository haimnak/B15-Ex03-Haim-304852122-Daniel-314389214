﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum eLicenseType
    {
        A,
        A2,
        AB,
        B1
    }

    public class Motorcycle : Vehicle
    {
        private readonly eLicenseType r_LicenseType;

        private readonly int r_HP;

        public Motorcycle(eLicenseType i_LicenseType, int i_HP)
        {
            this.r_LicenseType = i_LicenseType;
            this.r_HP = i_HP;
        }

        public eLicenseType LicenseType
        {
            get
            {
                return this.r_LicenseType;
            }
        }

        public int HP
        {
            get
            {
                return this.r_HP;
            }
        }
    }
}
