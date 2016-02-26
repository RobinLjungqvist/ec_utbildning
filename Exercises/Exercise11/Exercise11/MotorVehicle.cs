using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class MotorVehicle: Vehicle
    {
        private bool _engineIsRunning = false;
        public MotorVehicle(string vehicle): base (vehicle)
        {
            this._VehicleType = vehicle;
        }
        public void StartEngine()
        {
            _engineIsRunning = true;
        }
        public void StopEngine()
        {
            _engineIsRunning = false;
        }
        public bool isTheEngineRunning()
        {
            return _engineIsRunning;
        }
    }
}
