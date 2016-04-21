using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = string.Format("Hej * på * dig * ");
            StringBuilder sb = new StringBuilder();

            sb.Append(test);

            foreach (var item in sb.ToString())
            {
                if(item == '*')
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(item);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item);
                }
            }
            Console.ReadLine();
        }
    }
}
