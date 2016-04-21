using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,5,9,78,4,1,4,5,1

            List<int> intList = new List<int>()
            {
                1, 9, 78, 4, 1, 4, 5, 1

            };

            intList.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("-------------------------------");

            var newList = DistinctNumbers(intList);

            newList.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
        }

        public static List<int> DistinctNumbers(List<int> list)
        {
            List<int> DistinctNrList = new List<int>();
            foreach (var item in list)
            {
               if(!DistinctNrList.Contains(item))
                {
                    DistinctNrList.Add(item);
                }
            }
            return DistinctNrList;
        }
    }
}
