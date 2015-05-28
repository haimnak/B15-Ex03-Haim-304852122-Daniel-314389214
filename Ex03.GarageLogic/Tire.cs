using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    /*
        * Holds the tire properties
        */
    public class Tire
    {
        private readonly float r_MaxPressure;

        private readonly string r_Manufacturer;

        private float m_AirPressure;

        /*
         * Tire constructor
         */
        public Tire(float i_MaxPressure, string i_Manufacturer, float i_AirPressure)
        {
            this.r_MaxPressure = i_MaxPressure;
            this.r_Manufacturer = i_Manufacturer;
            this.m_AirPressure = i_AirPressure;
        }

        /* 
         * Get manufacturer name
         */
        public string Manufacturer
        {
            get
            {
                return r_Manufacturer;
            }
        }

        /*
         * Get/Set tire air pressure
         */
        public float AirPressure
        {
            get
            {
                return m_AirPressure;
            }

            set
            {
                float pumpedPressure = m_AirPressure + value;

                // Check we're adding a valid amount of pressure
                if (pumpedPressure < MaxPressure)
                {
                    m_AirPressure += value;
                }
            }
        }

        /* 
         * Get tire max air pressure
         */
        public float MaxPressure
        {
            get
            {
                return r_MaxPressure;
            }
        }

        public void inflateToMax()
        {
            m_AirPressure = r_MaxPressure;
        }

        public override string ToString()
        {
            return string.Format(@"Manufacturer: {0}
Current Air Pressure: {1}
Max Pressure: {2}", Manufacturer, AirPressure, MaxPressure);
        }
    }
}
