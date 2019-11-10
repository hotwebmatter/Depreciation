using System;
using System.Collections.Generic;
using System.Text;

namespace Depreciation
{
    class Vehicle
    {
        private string name;
        private double worth;
        private const double DEPRECIATION_RATE = 0.15;

        public Vehicle()
        {
            //default constructor
        }
        public Vehicle(string carName, double carValue)
        {
            // constructor with two arguments
            name = carName;
            worth = carValue;
        }

        // properties with mutators and accessors
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public double Worth
        {
            set { worth = value; }
            get { return worth; }
        }

        public void CalculateDepreciation()
        {
            worth = worth * (1 - DEPRECIATION_RATE);
        }
    }
}
