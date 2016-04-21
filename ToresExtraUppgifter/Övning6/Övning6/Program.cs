using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> myList = new List<User>();
            User Robin = new User();
            Robin.Name = "Robin";
            Robin.Age = 25;
            Robin.Country = "Sweden";
            Robin.City = "Helsingborg";
            myList.Add(Robin);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a search term: ");
                var search = Console.ReadLine();
                var result = searchUser(myList, search);
                result.ForEach(s => Console.WriteLine($"Name: {s.Name} Age: {s.Age} City: {s.City} Country: {s.Country} "));
                Console.ReadKey();
                
            }
        }

        public static List<User> searchUser(List<User> list, string SearchInput)
        {
            var tempList = new List<User>();

            foreach (var person in list)
            {
                if (person.Name.ToLower() == SearchInput.ToLower())
                {
                    tempList.Add(person);
                }
                else if (person.Age.ToString() == SearchInput)
                {
                    tempList.Add(person);
                }
                else if (person.City.ToLower() == SearchInput.ToLower())
                {
                    tempList.Add(person);
                }
                else if (person.Country.ToLower() == SearchInput.ToLower())
                {
                    tempList.Add(person);
                }
            }
            return tempList;
        }
    }
}
