using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Motorcycle : IVehicle
    {
        private double _speed;
        private const double _kmhToMs = 0.277777778;

        public Motorcycle()
        {
            //Randomly generates a speed between 10 - 101 to motorcycle added by user
            Random randSpeed = new Random();
            _speed = (double)randSpeed.Next(10, 101);
        }
        public double GetMetersPerSecond
        {
            //calculate the M/S and round it to 1 decimal
            //Read-only property for converting speed to m/s
            get { return Math.Round((_speed * _kmhToMs), 1); }
        }
        public void SetSpeed(double input)
        {
                _speed = input;
        }
        public double GetSpeed()
        {
            return _speed;
        }
    }
}
