using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var listofints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = listofints.Where(x => (x % 2) == 0).ToList();

            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }
            Console.ReadKey();
        }
    }
}
