using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binär_sökning
{
    class Person
    {
        private int personNr;
        private string name;

        public Person(string name, int personNr)
        {
            this.name = name;
            this.personNr = personNr;
        }
        public int PersonNr
        {
            get { return personNr; }
            set { personNr = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}
