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
            var oddNumbers = listofints.Where(x => (x % 2) == 1).ToList();
            var decscendingInts = listofints.OrderByDescending(x => x).ToList();

            Console.WriteLine("Even Numbers: ");
            evenNumbers.ForEach(x => Console.Write(x + " "));

            Console.WriteLine("\nOdd Numbers: ");
            oddNumbers.ForEach(x => Console.Write(x + " "));


            Console.WriteLine("\nDescending integers");
            decscendingInts.ForEach(x => Console.Write(x + " "));
             
            Console.ReadKey();
        }
    }
}
