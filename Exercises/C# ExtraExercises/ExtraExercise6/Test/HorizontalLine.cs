using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class HorizontalLine:Shapes
    {
        public HorizontalLine(int startPosX, int startPosY, int Length): base (startPosX: startPosX,startPosY: startPosY, width: Length, height: 1 )
        {
            
        }
    }
}
