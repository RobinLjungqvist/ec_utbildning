using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger myLogger = new Logger();
            myLogger.Log("Hello");
            myLogger.Log("my");
            myLogger.Log("name");
            myLogger.Log("is");
            myLogger.Log("Bertil.");

            foreach (var item in myLogger.LogPosts)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
            Console.WriteLine("That is all.");
            Console.ReadKey();
        }
    }
}
