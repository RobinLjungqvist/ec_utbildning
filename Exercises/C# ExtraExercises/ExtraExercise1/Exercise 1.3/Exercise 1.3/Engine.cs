using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._3
{
    class Engine
    {
        private bool engine = false;
        public void StartEngine(int currentGearOfTheCar)
        {
            if (engine == true)
                Console.WriteLine("The engine is already running!");
            else
            {
                if (currentGearOfTheCar == 1)
                {
                    engine = true;
                    Console.WriteLine("The engine started!");
                }
                else
                {
                    Console.WriteLine("The Gear must be in the first position.");
                }
            }
        }

        public void StopEngine()
        {
            if (engine == false)
            {
                Console.WriteLine("The engine isn't running.");
            }
            else
            {
                engine = false;
                Console.WriteLine("The engine has stopped running.");
            }
        }
    }
}
