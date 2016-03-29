using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition1
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiplication = new Multi();

            multiplication.PrintMultiplicationTable();
            Console.ReadKey();
        }
    }

    class Multi
    {
        public void PrintMultiplicationTable()
        {
            for (int i = 1; i < 10; i++)
            {
                var table = string.Empty;
                for (int j = 1; j < 10; j++)
                {
                    int nrToPrint = i * j;

                    table += nrToPrint + " \t";
                    
                }
                Console.WriteLine(table);
            }
        }

    }
}
