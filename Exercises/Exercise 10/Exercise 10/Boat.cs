﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Boat: Vehicle
    {
        private bool _engineIsRunning = false;
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
        public void StartEngine()
        {
            this._engineIsRunning = true;
        }
        public void StopEngine()
        {
            this._engineIsRunning = false;
        }
    }
}
