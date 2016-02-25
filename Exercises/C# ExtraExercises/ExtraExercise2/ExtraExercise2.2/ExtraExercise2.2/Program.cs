using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ascii asc = new Ascii();
            FourPartValidation valid = new FourPartValidation();
            asc.printAscii();
            int x = valid.getInt('x');
            int y = valid.getInt('y');
            int z = valid.getInt('z');
            bool flag = valid.getFlag();
            string Check = valid.Validate(x, y, z, flag).ToString();
            Console.WriteLine($"The validation of your input is = {Check}");
            Console.ReadKey();
        }
    }
}
