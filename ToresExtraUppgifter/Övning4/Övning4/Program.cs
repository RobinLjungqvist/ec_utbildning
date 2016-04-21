using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lotto lottery = new Lotto();

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Lottery");
                Console.WriteLine("[D]raw 7 numbers");
                Console.WriteLine("[Q]uit");

                ConsoleKeyInfo key = Console.ReadKey(true);


                switch (key.Key)
                {
                    case ConsoleKey.D:
                        var Numberlist = lottery.DrawSevenRandomNumbers();
                        lottery.printLottoNumbers(Numberlist);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(-1);
                        break;

                } 

            } while (true);
        }
    }
}
