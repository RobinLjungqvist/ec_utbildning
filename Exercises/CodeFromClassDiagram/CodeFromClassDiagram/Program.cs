using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFromClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryApplication app = new RegistryApplication();
            do
            {
                Console.Clear();
                app.Run();
                Console.ReadKey();
            } while (true);
        }
    }
}
