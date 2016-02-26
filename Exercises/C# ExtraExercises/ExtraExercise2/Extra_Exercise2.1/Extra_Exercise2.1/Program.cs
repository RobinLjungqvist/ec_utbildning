using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise2._1
{
    class Program
    {
        public static int[] inputs(int[] listInput)
        {
            int[] temp = new int[listInput.Length];
            int tempNR = 0;
            for (int i = 0; i < listInput.Length; i++)
            {

                Console.WriteLine("Enter Number {0}: ", i + 1);
                while (!(int.TryParse(Console.ReadLine(), out tempNR)))
                { Console.WriteLine("You didn't enter a number. Please enter number {0}.", i + 1); }
                temp[i] = tempNR;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int[] numbers;
            Console.WriteLine("How many numbers do you want to enter?");

            try
            {
                int numberOfNumbers = int.Parse(Console.ReadLine());
                numbers = new int[numberOfNumbers];
                numbers = inputs(numbers);
                Calculations calc = new Calculations();
                Console.WriteLine($"Smallest number is: {calc.SmallestNR(numbers)}");
                Console.WriteLine($"Biggest number is: {calc.BiggestNR(numbers)}");
                Console.WriteLine($"The average value of your numbers is: {calc.AverageValue(numbers)} ");
            Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
