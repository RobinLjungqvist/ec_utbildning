using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Person
    {
        public string _name { get; set; }
        public DateTime _dateOfbirth { get; }

        public Person(string name, DateTime DateOfBirth)
        {
            this._name = name;
            this._dateOfbirth = DateOfBirth;
        }
    }
}
