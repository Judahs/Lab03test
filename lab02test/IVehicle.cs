using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    interface IVehicle
    {
        string Name { get; }
        double GetMetersPerSecond { get; } //Force classes to have a getter for speed in m/s
        void SetSpeed(double input);
        double GetSpeed();
    }
    public enum VehicleType { unidentified, car, boat, motorcycle, all }
    public enum VehicleName { Namn, namn2, name3, name4, name5 }
}
