using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class LogApplication
    {
        ILogger newLogger;
        public LogApplication(ILogger logger)
        {
            this.newLogger = logger;
        }

        public void Run()
        {
            do
            {
                Console.WriteLine("-------Menu-------");
                Console.WriteLine("1. Add Message to log");
                Console.WriteLine("2. Print log");
                Console.WriteLine("3. Exit.");

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Enter your message: ");
                    var post = Console.ReadLine();
                    newLogger.Log(post);
                    Console.WriteLine($"Message logged. {newLogger.LogPosts.LastOrDefault()}");
                    Console.ReadKey();

                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("-------The logged posts--------");
                    foreach (var post in newLogger.LogPosts)
                    {
                        Console.WriteLine(post);
                    }
                    Console.WriteLine("-------------------------------");
                    Console.ReadKey();

                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Choose an option with the number keys.");
                    Console.ReadKey();
                }

                Console.Clear();
            } while (true);


        }
    }
}
