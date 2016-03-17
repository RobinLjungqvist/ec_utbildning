using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                var loader = new ListLoader();
                loader.Load();
                Console.WriteLine("Please enter a search term: ");
                string input = Console.ReadLine();
                var filteredlist = loader.SearchFile(input);

                if (filteredlist.Count != 0)
                {
                    Console.WriteLine("*---Search Results---*");
                    foreach (var line in filteredlist)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("*--------------------*");
                }
                else
                {
                    Console.WriteLine("Your search yielded no results!");
                }
                Console.ReadKey(); 
            } while (true);
        }
    }
}
