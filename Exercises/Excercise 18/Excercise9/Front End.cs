using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class FrontEnd
    {
        Registry myRegistry = new Registry();
        public void Menu()
        {
            do
            {
                Console.WriteLine("Welcome to the Employee Registry!");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Add Employee\r\n2. Remove employee\r\n3. Show Registry\r\n4. Show filtered registry\r\n5.Exit");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        myRegistry.AddEmployeeToRegistry();
                        Console.ReadLine();
                        break;
                    case '2':
                        Console.WriteLine("Please enter the employees social security number:");
                        string ssNR = Console.ReadLine();
                        myRegistry.RemoveEmployeeFromRegistry(ssNR);
                        Console.ReadLine();
                        break;
                    case '3':
                        myRegistry.ShowRegistry();
                        Console.ReadLine();
                        break;
                    case '4':
                        myRegistry.PrintFilteredRegistry(myRegistry.FilterRegistry());
                        Console.ReadLine();
                        break;
                    case '5':
                        return;
                    default:
                        Console.WriteLine("Please enter one of the numbers to choose and option.");
                        break;
                }
                Console.Clear();
            } while (true);
        }
    }
}
