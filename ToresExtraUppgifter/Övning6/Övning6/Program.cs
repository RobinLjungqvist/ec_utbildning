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
            User Ronni = new User("Ronni","Helsingborg","Sweden",54);
            User Tomi = new User("Tomi", "Tampere", "Finland", 30);
            User Roger = new User("Roger", "Gislaved", "Sweden", 54);
            myList.Add(Robin);
            myList.Add(Ronni);
            myList.Add(Roger);
            myList.Add(Tomi);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a search term: ");
                var search = Console.ReadLine();
                var result = SearchUser(myList, search);
                result.ForEach(s => Console.WriteLine($"Name: {s.Name} Age: {s.Age} City: {s.City} Country: {s.Country} "));
                Console.ReadKey();
                var newResult = GetMaxAgedUser(myList);
                var UserVar = (newResult.Count > 1) ? "users" : "User";
                Console.WriteLine($"The highest aged {UserVar} registred are: ");
                newResult.ForEach(s => Console.WriteLine($"Name: {s.Name} Age: {s.Age} City: {s.City} Country: {s.Country} "));
                Console.ReadKey();

            }
        }

        public static List<User> SearchUser(List<User> list, string SearchInput)
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

        public static List<User> GetMaxAgedUser(List<User> list)
        {
            var templist = new List<User>();
            var highestAge = 0;

            foreach (var item in list)
            {
                if (item.Age >= highestAge)
                {
                    highestAge = item.Age;
                }
            }
            foreach (var item in list)
            {
                if (item.Age == highestAge)
                {
                    templist.Add(item);
                }
            }
            return templist;
        }
    }
}
