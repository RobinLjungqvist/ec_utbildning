using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Dot : Shapes
    {
        public Dot(int startPosX, int startPosY): base (startPosX, startPosY)
        {
            this._DimensionX = 1;
            this._DimensionY = 1;
        }
    }
}
