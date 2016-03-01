using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise13
{
    class BirthdayManager
    {
        public List<Person> PersonList { get; set; }
        public Person CreatePerson()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var dateOfBirth = AskForBirthDate();

            var person = new Person(name, dateOfBirth);

            return person;
            

        }
        public DateTime AskForBirthDate()
        {
            Console.WriteLine("What is your date of birth? YYYY-MM-DD");
            var userinput = Console.ReadLine();
            var dateOfBirth = new DateTime();
            if (DateTime.TryParse(userinput, out dateOfBirth))
            {
                return dateOfBirth;
            }
            else
            {
                return AskForBirthDate();
            }
        }

        public void PrintBirthdayInfo(Person currentPerson)
        {
            DateTime now = DateTime.Now;
            var age = (now - currentPerson._dateOfbirth);
            var nextBirthday = new DateTime(now.Year, currentPerson._dateOfbirth.Month, currentPerson._dateOfbirth.Day);
            if (nextBirthday < now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            var daysUntilBirthday = (nextBirthday - now).Days;
            var hundrethbirthday = currentPerson._dateOfbirth.AddYears(100);

            var culture = CultureInfo.CreateSpecificCulture("en-US");
            
            var message = string.Format(
               $"Hello {currentPerson._name}!\r\n" + 
               $"You are {age.Days/365} years old and it's {daysUntilBirthday} until your birthday!\r\n" +
               $"You are going to turn 100 years old {hundrethbirthday.ToString("D", culture)}");
            Console.WriteLine(message);
        }
    }
}


