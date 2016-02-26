using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int age = 0;
            string work = string.Empty;
            string jobtitle = string.Empty;

            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Please enter where you work:");
            work = Console.ReadLine();

            Console.WriteLine("Please enter your date of birth: YYYY-MM-DD");
            DateTime myDT = DateTime.Parse(Console.ReadLine());
            age = DateTime.Now.Year - myDT.Year;
            if (DateTime.Now.Month < myDT.Month)
            {
                if (DateTime.Now.Day < myDT.Day)
                {
                    age = age - 1;
                }
            }
            Console.WriteLine("Please enter your job title: ");
            jobtitle = Console.ReadLine();
            Console.Clear();

            string str = string.Format("Hello, {0}.\r\nYou are {1} years old and were born in {2} and work at {3},\r\nwhere {4} is your title.", name, age, myDT.Year, work, jobtitle);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
