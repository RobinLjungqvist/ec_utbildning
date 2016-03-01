using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            var BM = new BirthdayManager();
            var person1 = BM.CreatePerson();
            BM.PrintBirthdayInfo(person1);
            Console.ReadKey();
            Console.Clear();
            BM.stretchTask(person1);
            Console.ReadKey();
        }
    }
}
