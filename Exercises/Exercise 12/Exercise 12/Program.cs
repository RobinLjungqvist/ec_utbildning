using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new DateTimeLogger();
            var application = new LogApplication(logger);
            application.Run();
        }
    }
}
