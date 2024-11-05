using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Part1
{
    internal class odometer
    {
        private int miles;
        private double fuelUsed;


        public odometer() { miles = 0; fuelUsed = 0.0; }

        public odometer(int _miles, double _fuelUsed)
        {
            miles = _miles;
            fuelUsed = _fuelUsed;
        }

        public int Miles { get => miles; set => miles = value; }
        public double FuelUsed { get => fuelUsed; set => fuelUsed = value; }
        //methods
        public void reset()
        {
            Miles = 0;
            FuelUsed = 0.0;
        }

        public void add(int m, double f)
        {
            Miles += m; //Miles = Miles + m;

            FuelUsed += f; //FuelUsed = FuelUsed + f;
        }
        public double MPG()
        {
            return Miles / FuelUsed;
        }

        public String toString()
        {
            return "" + Miles + " miles driven " + FuelUsed + " Fuel Used";
        }
    }
}
