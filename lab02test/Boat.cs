﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Boat : IVehicle
    {
        private double _speed;
        private const double _knotsToMs = 0.5144444; 

        public Boat()
        {
            //Randomly generates a speed between 10 - 101 to boat added by user
            Random randSpeed = new Random();
            _speed = (double)randSpeed.Next(10, 101);
        }
        public double GetMetersPerSecond
        {
            //calculate the M/S and round it to 1 decimal
            //Read-only property for converting speed to m/s
            get { return Math.Round((_speed * _knotsToMs), 1); }
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
