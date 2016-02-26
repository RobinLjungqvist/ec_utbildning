using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Employee
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string socialSecurityNumber;
        private string hourlyWage;

        public string HourlyWage
        {
            get { return hourlyWage; }
            set { hourlyWage = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }
        public string SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public Employee(string name, string lastname, string socNR, string wage)
        {
            this.firstName = name;
            this.lastName = lastname;
            this.socialSecurityNumber = socNR;
            this.hourlyWage = wage;
        }
        public Employee(string socNR)
        {
            this.socialSecurityNumber = socNR;
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Name: {FullName}\r\nSocial Security Number: {SocialSecurityNumber}\r\nHourly wage: {HourlyWage}");
            Console.WriteLine("------------------------------");
        }

    }
}
