using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise_States
{
    enum State
    {
        Running,
        Paused,
        Stopped
    }
    class Program
    {
        static void Main(string[] args)
        {
            Process myProcess = new Process();

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Welcome to the process!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("------------------------");
                Console.WriteLine("[R]un");
                Console.WriteLine("[P]ause");
                Console.WriteLine("[S]top");
                Console.WriteLine("[G]et state");
                Console.WriteLine("[Q]uit");
                Console.WriteLine("");
                Console.Write(">");



                key = Console.ReadKey(true);

                switch(key.Key)
                {
                    case ConsoleKey.R:
                        myProcess.Start();
                        break;
                    case ConsoleKey.P:
                        myProcess.Pause();
                        break;
                    case ConsoleKey.S:
                        myProcess.Stop();
                        break;
                    case ConsoleKey.G:
                        myProcess.GetState();
                        break;
                    case ConsoleKey.Q:
                        return;
                    case ConsoleKey.Escape:
                        return;
                }


                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();


            } while (true);

        }
    }
    class Process
    {
        private State state = State.Stopped;

        public void Start()
        {
            state = State.Running;
            Console.WriteLine("Process is now running.");

        }
        public void Stop()
        {
            if (state != State.Paused)
            {
                state = State.Stopped;
                Console.WriteLine("Process has stopped.");
            }
            else
            {
                Console.WriteLine("Can't go from stopped to paused.");
            }
        }
        public void Pause()
        {

            if (state != State.Stopped)
            {
                state = State.Paused;
                Console.WriteLine("Process is paused.");

            }
            else
            {
                Console.WriteLine("Can't go from paused to stopped.");
            }
            
        }
        public void GetState()
        {
            Console.WriteLine($"The process is {state}");
        }
    }

}
