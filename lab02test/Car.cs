using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Car : IVehicle
    {
        private double _speed;
        private string _name;
        private const double _mphToMs = 0.44704; 

        public Car()
        {
            //Randomly generates a speed between 10 - 101 to car added by user
            Random randSpeed = new Random();
            _speed = (double)randSpeed.Next(10, 101);
        }

        public string Name
        {
            get { return _name; }
        }

        public double GetMetersPerSecond
        {
            //calculate the M/S and round it to 1 decimal
            //Read-only property for converting speed to m/s
            get { return Math.Round((_speed * _mphToMs), 1); }   
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
