using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFromClassDiagram
{
    class PersonRegistry : IPersonRegistry
    {
        List<Person> persons;

        public PersonRegistry()
        {
            persons = new List<Person>();
        }
        public void AddPerson(string num, string fName, string lName)
        {
            var person = new Person();
            person.SocialSecurityNum = num;
            person.FirstName = fName;
            person.LastName = lName;
            persons.Add(person);
        }

        public string FindPerson(string num)
        {
            string personInfo = string.Empty;
            foreach (var person in persons)
            {
                if(person.SocialSecurityNum == num)
                {
                    personInfo = person.FullName;
                }
            }

            return personInfo;
        }

        public List<string> GetListWithNames()
        {
            var ListOfNames = new List<string>();
            foreach (var person in persons)
            {
                ListOfNames.Add(person.FullName);
            }
            return ListOfNames;
        }

        public bool HasPerson(string num)
        {
            foreach (var person in persons)
            {
                if(person.SocialSecurityNum == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
