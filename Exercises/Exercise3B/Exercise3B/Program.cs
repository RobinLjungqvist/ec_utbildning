using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3B
{
    class Program
    {
        public static int getNR()
        {
            int number;
            if(int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("You must enter a number.");
            return getNR();

        }
        public static void Calculator()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("A. Add\r\nB. Subtract\r\nC. Divide\r\nD. Multiply");
            ConsoleKeyInfo key;
            Console.Write("Your choice: ");
            key = Console.ReadKey(false);
            var choice = key;
            int number1 = 0;
            int number2 = 0;

            if (choice.KeyChar == 'a' || choice.KeyChar == 'b' || choice.KeyChar == 'c' || choice.KeyChar == 'd')
            {
                Console.Write("\r\nEnter your first number: ");
                number1 = getNR();

                Console.Write("Enter your second number: ");
                number2 = getNR();
            }

            switch (choice.KeyChar)
            {
                case 'a':
                    Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
                    break;
                case 'b':
                    Console.WriteLine("{0} - {1} = {2}", number1, number2, (number1 - number2));
                    break;
                case 'c':
                    if (number2 > 0)
                    Console.WriteLine("{0} / {1} = {2}", number1, number2, (number1 / number2));
                    else
                        Console.WriteLine("Error. Can't divide by zero.");
                    break;
                case 'd':
                    Console.WriteLine("{0} * {1} = {2}", number1, number2, (number1 * number2));
                    break;
                default:
                    Console.WriteLine("\r\nYou didn't enter a valid operand");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to the calculator");
                Console.WriteLine("A. Calculate\r\nB. Exit");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                var choice = key;
                switch(choice.KeyChar)
                {
                    case 'a':
                        Calculator();
                        break;
                    case 'b':
                        Environment.Exit(-1);
                        break;
                }
                    
            } while (true);
        }
    }
}
