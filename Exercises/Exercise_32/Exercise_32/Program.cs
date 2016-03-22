using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_32
{
    class Program
    {
        static void Main(string[] args)
        {

            var superuser = new Superuser()
            {
                Name = "Clark Kent",
                Age = 22,
                Country = "United States of Whatever"

            };
            var user = new User()
            {
                Name = "Kenta Kent",
                Age = 32,
                Country = "Svalöv"

            };
            var emp = new Employee();

            if(emp is Employee)
            {
                Console.WriteLine("Emp is employee");
            }

            if (superuser is User)
            {
                Console.WriteLine("Superuser is User");
            }
            else
            {
                Console.WriteLine("Superuser isn't user");
            }

            if (emp is User)
            {
                Console.WriteLine("Employee is User");
            }
            else
            {
                Console.WriteLine("Employee isn't user");
            }
            if (user is User)
            {
                Console.WriteLine("User is User");
            }
            else
            {
                Console.WriteLine("User isn't user");
            }
            if (user is Superuser)
            {
                Console.WriteLine("User is Superuser");
            }
            else
            {
                Console.WriteLine("User isn't Superuser");
            }

            //////////////////////////////////////////////////
            object tester = new Superuser()
            {
                Name = "Testvald",
                Age = 33,
                Country = "TestLand"
            };

            var test = tester as Employee;


            Console.WriteLine("test is an employee: " + (test is Employee).ToString());

            var test2 = tester as Superuser;
            Console.WriteLine("test is a superuser: " + (test2 is Superuser));



            Console.ReadKey();
        }
    }
}
