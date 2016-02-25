using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise2._2
{
    class FourPartValidation
    {
        public int getInt(char value)
        {
            Console.WriteLine($"Please enter the value for {value}: ");
            int result = 0;
            if (int.TryParse(Console.ReadLine(), out result))
            {
                return result;
            }
            return getInt(value);
        }
        public bool getFlag()
        {
            Console.WriteLine("Is the flag [T]rue or [F]alse?");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.T:
                    return true;
                case ConsoleKey.F:
                    return false;
                default:
                    Console.WriteLine("Answer with T or F...");
                    return getFlag();
            }
        }
        public bool Validate(int x, int y, int z, bool flag)
        {
            if (z > 10 && z < 20 && flag == true)
            {
                return true;
            }
            else if (y > 10 && y < 20 && z == 0 && flag == true)
            {
                return true;
            }
            else if (x == 5 && y == 3 && z > 99 && flag == false)
            {
                return true;
            }
            else return false;
        }
    }
}
