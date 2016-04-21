using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> intList = new List<int>() { 1, 5, 9, 78, 4, 1, 4, 5, 1 };

            oddList(intList).ForEach(s => Console.WriteLine(s));
            Console.WriteLine("--------------------------");
            Console.WriteLine(MaxNumber(intList));
            Console.WriteLine("--------------------------");
            Console.WriteLine(MinNumber(intList));
            Console.WriteLine("--------------------------");
            Console.ReadKey();


        }

        public static List<int> oddList(List<int> list)
        {
            List<int> templist = new List<int>();
            foreach (var number in list)
            {
                if ((number % 2) == 1)
                {
                    templist.Add(number);
                }
            }
            return templist;
        }

        public static int MaxNumber(List<int> list)
        {
            int highestNumber = 0;
            foreach (var number in list)
            {
                if (number > highestNumber)
                {
                    highestNumber = number;
                }
            }
            return highestNumber;
        }

        public static int MinNumber(List<int> list)
        {
            int lowestNumber = list[0];
            foreach (var number in list)
            {
                if (number < lowestNumber)
                {
                    lowestNumber = number;
                }
            }
            return lowestNumber;
        }
    }
}
