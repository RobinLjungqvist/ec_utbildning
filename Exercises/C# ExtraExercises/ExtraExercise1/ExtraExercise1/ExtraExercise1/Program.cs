using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise1
{
    class Program
    {

        public static int HowManyHellos(string[] strArray)
        {
            int numbersOfHellos = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].ToLower() == "hello")
                {
                    numbersOfHellos++;
                }
            }
            return numbersOfHellos;
        }
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "Hello", "Max", "hi", "HeLlo" };
            Console.WriteLine($"The numbers of hello in the array is: {HowManyHellos(myArray)}");
            Console.ReadKey();
        }
    }
}
