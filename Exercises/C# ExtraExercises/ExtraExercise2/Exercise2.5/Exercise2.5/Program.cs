using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Board arr = new Board();
                int[,] boardArr = new int[20, 20];
                boardArr = arr.addValues(boardArr);
                arr.printArr(boardArr);
                ConsoleKeyInfo key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.Escape)
                {
                    return;
                }
                Console.WriteLine(arr.CountNeighbour(0,19, boardArr));
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
