using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Shapes
    {
        public int _StartPosY { get; set; }
        public int _StartPosX { get; set; }

        public bool _Filled { get; set; }

        int _dimensionX = 0;
        int _dimensionY = 0;

        
        public int _DimensionX
        {
            get { return this._dimensionX; }
            set
            {
                if (!(value > Console.WindowWidth))
                {
                    this._dimensionX = value;
                }
            }
        }
        public int _DimensionY
        {
            get { return this._dimensionY; }
            set
            {
                if (!(value > Console.WindowHeight))
                {
                    this._dimensionY = value;
                }
            }
        }
        public Shapes(int startPosX, int startPosY, int width, int height)
        {
            this._StartPosY = startPosX;
            this._StartPosX = startPosY;
            this._DimensionX = width;
            this._DimensionY = height;
        }
        public Shapes(int startPosX, int startPosY)
        {
            this._StartPosY = startPosX;
            this._StartPosX = startPosY;         
        }
    }
}

