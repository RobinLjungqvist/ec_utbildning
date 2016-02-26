using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._3
{
    class Gear
    {
        private int currentGear = 0;

        public int CurrentGear
        {
            get { return currentGear; }
            set { currentGear = value; }
        }
        public void MoveGear()
        {
            do
            {
                Console.WriteLine($"Current gear: {currentGear}");
                Console.WriteLine("Do you want to move it [U]p or [D]own?");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'u':
                        if (currentGear <= 5)
                        {
                            currentGear++;
                            Console.WriteLine("The gear has shifted up.");
                        }
                        else
                        {
                            Console.WriteLine("The car doesn't have more than 5 gears.");
                        }
                        return;
                    case 'd':
                        if (currentGear > 0)
                        {
                            currentGear--;
                            Console.WriteLine("The gear has shifted down");
                        }
                        else
                        {
                            Console.WriteLine("You cant get any lower than gear 0");
                        }
                        return;
                    default:
                        Console.WriteLine("U for Up, D for down.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (true);

        }
    }
}
