using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                var loader = new ListLoader();
                Console.WriteLine("Please enter a year from which you want to start your search: ");
                string input = Console.ReadLine();

                int min = 0;
                int max = 0;

                while (!int.TryParse(input, out min))
                {
                    Console.WriteLine("You must enter a number! Try again!");
                }

                Console.WriteLine("Please enter a year from which you want to end your search: ");

                string input2 = Console.ReadLine();
                while (!int.TryParse(input2, out max))
                {
                    Console.WriteLine("You must enter a number! Try again!");
                }

                var List = loader.search(min, max);


                if (List.Count != 0)
                {
                    Console.WriteLine("NAME\t\tYEAR\t\tDESCRIPTION");
                    foreach (var item in List)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", item._Name, item._Year, item._Description);

                    } 
                }
                else
                {
                    Console.WriteLine("Search yielded no results.");
                }
                Console.ReadKey(); 
            } while (true);

        }
    }
}
