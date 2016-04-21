using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reptition5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 101; i++)
            {

                if (i < 16)
                {
                    Console.Write(0 + i.ToString("x") + " ");
                }
                else
                {
                    Console.Write(i.ToString("x") + " ");

                if ((i % 15) == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
