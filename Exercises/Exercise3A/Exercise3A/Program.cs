using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            ForLoop(userInput());
            Console.Write("Please enter a number: ");
            WhileLoop(userInput());
            Console.Write("Please enter a number: ");
            DoWhileLoop(userInput());
            Console.ReadLine();
        }
        public static void ForLoop(int x)
        {
            int result = 0;
            string resultToPrint = string.Empty;
            for (int i = 1; i <= x; i++)
            {
                result = result + i;
                if (i != x)
                {
                    resultToPrint += i + "+";
                }
                else
                {
                    resultToPrint += i;
                }
            }
            resultToPrint = resultToPrint + " = " + result;
            Console.WriteLine(resultToPrint);
        }
        public static void WhileLoop(int x)
        {
            int index = 1;
            int result = 0;
            string resultToPrint = string.Empty;
            while (index <= x)
            {
                result = result + index;
                if (index != x)
                {
                    resultToPrint += index + "+";
                }
                else
                {
                    resultToPrint += index;
                }
                index++;
            }
            resultToPrint = resultToPrint + " = " + result;
            Console.WriteLine(resultToPrint);
        }
        public static void DoWhileLoop(int x)
        {
            int index = 1;
            int result = 0;
            string resultToPrint = string.Empty;
            do
            {
                result = result + index;
                if (index != x)
                {
                    resultToPrint += index + "+";
                }
                else
                {
                    resultToPrint += index;
                }
                index++;
            } while (index <= x);
            resultToPrint = resultToPrint + " = " + result;
            Console.WriteLine(resultToPrint);
        }
        public static int userInput()
        {
            int number;
            if(int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("You must enter a positive number.");
            return userInput();
        }

    }
}

