using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kalle = new Employee("Kalle", "Kaviarsson", "780522-3256", "110 kr/h");
            Console.WriteLine($"Namn: {Kalle.FullName}\r\nSocial Security Number: {Kalle.SocialSecurityNumber}\r\nHourly Wage: {Kalle.HourlyWage}");
            Console.ReadLine();
        }
    }
}
