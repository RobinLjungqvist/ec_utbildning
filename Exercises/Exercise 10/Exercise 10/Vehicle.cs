using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Vehicle
    {
        private string _vehicleType;

        public string _VehicleType 
        {
            get { return this._vehicleType; }
            set { this._vehicleType = value; }
        }


        public Vehicle(string vehicletype)
        {
            this._vehicleType = vehicletype;
        }

        public string DescribeVehicle()
        {
            return _vehicleType;
        }
    }
}
