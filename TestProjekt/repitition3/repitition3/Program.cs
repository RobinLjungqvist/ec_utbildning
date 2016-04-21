using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repitition3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i > 0; i--)
            {
                if ((i % 2) == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
