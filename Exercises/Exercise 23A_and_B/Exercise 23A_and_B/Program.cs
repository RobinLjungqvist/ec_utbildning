using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23A_and_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 23 A
            var checkbox = new Checkbox();

            checkbox.CheckBoxStatus = null;
            Console.WriteLine("Checkbox: " + checkbox.Description);

            checkbox.CheckBoxStatus = false;
            Console.WriteLine("Checkbox: " + checkbox.Description);

            checkbox.CheckBoxStatus = true;
            Console.WriteLine("Checkbox: " + checkbox.Description);

            Console.ReadKey();

            // Exercise 23 B


            Coordinate coord1;
            coord1._x = 4;
            coord1._y = 4;

            Coordinate? coordinate1 = coord1;

            Coordinate coord2;
            coord2._x = 0;
            coord2._y = 4;

            Coordinate? coordinate2 = null;

            Coordinate coord3;
            coord3._x = 0;
            coord3._y = 4;

            Coordinate? coordinate3 = coord3;

            if (coordinate1.HasValue && coordinate2.HasValue && coordinate3.HasValue)
                {
                    var myTriangle = new Triangle(coordinate1.Value, coordinate2.Value, coordinate3.Value);

                    foreach (var coord in myTriangle.triangleCoordinates)
                    {
                        Console.WriteLine($"{coord._x}, {coord._y}");
                    } 
                }
            else
            {
                Console.WriteLine("One of the input coordinates had no value");
            }

            Console.ReadKey();

        }
    }
}
