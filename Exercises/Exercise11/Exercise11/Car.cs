using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Car : MotorVehicle
    {
        public Car(): base ("Car")
        {

        }
         
        public override string DescribeVehicle()
        {
            return base.DescribeVehicle() +  (isTheEngineRunning() ? "It's running!":" It's not running");
        }
    }
}
