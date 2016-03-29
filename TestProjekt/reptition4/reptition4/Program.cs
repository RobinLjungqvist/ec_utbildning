using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reptition4
{
    class Program
    {
        public static bool IsPrime(int input)
        {
            if (input == 1)
                return false;
            if (input == 2)
                return true;
            if ((input % 2 == 0))
                return false;

            for(int i = 3;  i < input; i+=2)
            {
                if ((input % i) == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if(IsPrime(i))
                {
                    Console.Write(i + "  ");
                }
            }
            Console.ReadKey();
        }
    }
}
