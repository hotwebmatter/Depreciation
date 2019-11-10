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

        // properties only receiving the data
        public string Name
        {
            set { name = value; }
        }

        public double Worth
        {
            set { worth = value; }
        }
    }
}
