using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23A_and_B
{
    class Triangle
    {
        public List<Coordinate> triangleCoordinates { get; }

        public Triangle(Coordinate one, Coordinate two, Coordinate three)
        {
            triangleCoordinates = new List<Coordinate>()
            {
                one,
                two,
                three
            };
        }
    }
}
