using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Car : Vehicle
    {
        private bool engineIsRunning = false;
        public Car(): base ("Car")
        {
        }
        public void StartEngine()
        {
            engineIsRunning = true;
        }
        public void StopEngine()
        {
            engineIsRunning = false;
        }
        public override string DescribeVehicle()
        {
            return base.DescribeVehicle() + $" Is the engine running: {engineIsRunning.ToString()}";
        }
    }
}
