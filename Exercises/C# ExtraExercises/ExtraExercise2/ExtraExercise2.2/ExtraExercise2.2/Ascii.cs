using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise2._2
{
    class Ascii
    {
        public void printAscii()
        {
            for (int i = 0; i <= 255; i++)
            {
                string asciisymbol ="'" +  Convert.ToChar(i) + "'";

                if (i == 10 )
                {
                    asciisymbol = "newline";
                }
                else if ( i == 13)
                {
                    asciisymbol = "Carriage return";
                }

                var AsciiLine = string.Format(@"Dec: {0,-2}| Hex:{0:X} | Bin: {1,-2}| Oct:{2}| Ascii symbol: {3,-2} ", i, Convert.ToString(i, 2), Convert.ToString(i, 8), asciisymbol);
                Console.WriteLine(AsciiLine);
            }
        }
    }
}
