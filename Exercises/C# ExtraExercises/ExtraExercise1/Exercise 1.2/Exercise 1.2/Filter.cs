using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._2
{
    class Filter
    {
        public static string RemoveAllSpaces(string input) // Gjorde denna static för att slippa instansiera Filter i program.
        {
            string result = "";
            foreach (char character in input)
            {
                if (!(character == ' '))
                {
                    result += character;
                }

            }
            return result;
        }
    }
}
