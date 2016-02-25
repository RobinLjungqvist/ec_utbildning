using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "R o b i n_L j u n g q v i s t";
            var result = Filter.RemoveAllSpaces(input);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
