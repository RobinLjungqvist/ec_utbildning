using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFromClassDiagram
{
    class RegistryApplication
    {
        PersonRegistry registry;

        public RegistryApplication()
        {
            registry = new PersonRegistry();
        }

        public void Run()
        {
            Console.WriteLine("Welcome to registry. Please choose an operation.");
            Console.Write(
                "A. Add person to registry\n" +
                "G. Get Person\n" +
                "F. Find all persons\n" +
                "Q. Quit\n");

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.A:
                    AddPersonToRegistry();
                    break;
                case ConsoleKey.G:
                    ListPerson();
                    break;
                case ConsoleKey.F:
                    ListAllPersons();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(-1);
                    break;
                default:
                    break;
            }
        }
        private void AddPersonToRegistry()
        {
            var num = ReadPersonData("Social Security Number");
            var fName = ReadPersonData("first name");
            var lName = ReadPersonData("last name");

            registry.AddPerson(num, fName, lName);
        }
        private void ListPerson()
        {
            var num = ReadPersonData("Social Security Number");
            Console.WriteLine(registry.FindPerson(num));
        }
        private void ListAllPersons()
        {
            var listOfNames = registry.GetListWithNames();

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
        private string ReadPersonData(string whatParaMeterToInput)
        {
            Console.WriteLine($"Please input {whatParaMeterToInput}:");
            var readInput = Console.ReadLine();

            return readInput;
        }
    }
}
