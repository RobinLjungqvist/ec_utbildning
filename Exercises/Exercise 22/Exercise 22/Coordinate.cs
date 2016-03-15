using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    public struct Coordinate
    {
        public int _X { get; set; }
        public int _Y {get; set;}

        public Coordinate(int x, int y)
        {
            _X = x;
            _Y = y;
        }
    }
}