using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int numberOfTimes = 10000000;
            var arrayList = new ArrayList();

            sw.Start();
            for (int i = 0; i < numberOfTimes; i++)
            {
                arrayList.Add(i);
            }
            sw.Stop();
            Console.WriteLine("ArrayList: " + sw.ElapsedMilliseconds + "milliseconds");
            sw.Reset();

            sw.Start();
            var listOfInts = new List<int>();
            for (int i = 0; i < numberOfTimes; i++)
            {
                listOfInts.Add(i);
            }
            sw.Stop();
            Console.WriteLine("Generic List: " + sw.ElapsedMilliseconds + "milliseconds");

            sw.Reset();
            sw.Start();
            var ArrayOfInts = new int[numberOfTimes];
            for (int i = 0; i < numberOfTimes; i++)
            {
                ArrayOfInts[i] = i;
            }
            sw.Stop();
            Console.WriteLine("Array of ints: " + sw.ElapsedMilliseconds + "milliseconds");

            sw.Reset();
            sw.Start();
            var DictionaryOfInts = new Dictionary<int, int>();
            for (int i = 0; i < numberOfTimes; i++)
            {
                DictionaryOfInts[i] = i;
            }
            sw.Stop();
            Console.WriteLine("Dictionary | Key: int| Value: int |: " + sw.ElapsedMilliseconds + "milliseconds");

            Console.ReadKey();

            /*
            The generic list is a little bit slower than the array if integers.
            But the fact that a list is dynamic makes the minimal drop
            in performance insignificant, unless one is dealing with very large numbers several times.

            As we have discussed during lectures that arrayList is a thing from the past,
            as Generic lists outperform ArrayList of objects in all aspects.

            With generics we also get rid of alot of problems concerning unboxing of the data from the objects.
            In other words; We don't have to recast our data after unboxing objects.


            */

        }
    }
}
