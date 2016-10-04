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
        private string _name;
        private const double _knotsToMs = 0.5144444; 

        public Boat()
        {
            //Randomly generates a speed between 10 - 101 to boat added by user
            Random randSpeed = new Random();
            _speed = (double)randSpeed.Next(10, 101);
            _name = RandomNames();
        }

        public Boat(double _speed, string _name)
        {
            //Overloaded constructor, used to create instances of objects from saved data
            this._speed = _speed;
            this._name = _name;
        }

        public string Name
        {
            get { return _name; }
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

        public string RandomNames()
        {
            List<string> randomNamesList = new List<string>() { "Petrus", "Judas Taddeus", "Johannes", "Judas Iskariot", "Matteus", "Tomas", "Jakob", "Andreas", "Filippos", "Jakob", "Simon", "Bartolomaios" };
            int l = randomNamesList.Count;
            Random r = new Random();
            int num = r.Next(l);
            return randomNamesList[num];
        }
    }
}
