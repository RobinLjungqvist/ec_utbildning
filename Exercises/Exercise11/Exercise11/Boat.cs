using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Boat: MotorVehicle
    {
        private int _nrOfSails = 0;

        public int _NrOfSails
            {
            get { return this._nrOfSails; }
            set { this._nrOfSails = value; }
            }
        

        public Boat(int nrOfSails): base ("Boat")
        {
            this._nrOfSails = nrOfSails;
        }

        public override string DescribeVehicle()
        {
            return base.DescribeVehicle() + (isTheEngineRunning() ? " It's running!" : " It's not running");
        }
    }
}
