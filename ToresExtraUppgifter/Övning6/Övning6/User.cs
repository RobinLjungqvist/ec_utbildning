using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning6
{
    class User
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Age { get; set; } 

        public User(string name, string city, string country, int age)
        {
            this.Name = name;
            this.City = city;
            this.Country = country;
            this.Age = age;
        }
        public User()
        {

        }
    }
}
