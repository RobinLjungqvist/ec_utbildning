using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var coord1 = new Coordinate(10, 10);
            var coord2 = new Coordinate();

            coord2 = coord1;

            coord2._X = 5;
            coord2._Y = 5;

            Console.WriteLine($"Coord1: {coord1._X}, {coord1._Y} ");
            Console.WriteLine($"Coord2: {coord2._X}, {coord2._Y} ");

            Console.ReadKey();

        }
    }
}
