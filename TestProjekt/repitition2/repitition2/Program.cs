using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repitition2
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessingGame game = new GuessingGame();
            GUI UserInterface = new GUI(game);
            UserInterface.Run();


        }
    }
    class GuessingGame
    {
        int hiddenNumber;
        public Gamestate state { get; set; }

        public GuessingGame()
        {
            Random rnd = new Random();
            this.hiddenNumber = rnd.Next(1, 101);
            state = Gamestate.Running;
        }

        public void setHiddenNumber()
        {
            Random rnd = new Random();
            hiddenNumber = rnd.Next(1,101);
            
        }

        public void GuessNumber(int input)
        {
            if(input == hiddenNumber)
            {
                state = Gamestate.Correct;
            }
            else
            {
                state = Gamestate.Wrong;
            }
        }
        public string HigherOrLower(int input)
        {
            if (input > hiddenNumber)
            {
                return "The number is lower!";
            }
            else
            {
                return "The number is higher!";
            }
        }

    }

    class GUI
    {
        GuessingGame _game;
        public GUI(GuessingGame game)
        {
            this._game = game;

        }
        public void Run()
        {
            int input = 0;
            Console.WriteLine("Welcome to the guessing game!");
            while(_game.state != Gamestate.Quit)
            {

                switch (_game.state)
                {
                    case Gamestate.Running:
                        input = GetGuess();
                        _game.GuessNumber(input);
                        break;
                    case Gamestate.Correct:
                        Console.WriteLine("You were correct!");
                        _game.state = Gamestate.Quit;

                        break;
                    case Gamestate.Wrong:
                        Console.WriteLine("You were wrong! {0}", _game.HigherOrLower(input));
                        _game.state = Gamestate.Running;
                        break;

                }
                Console.ReadKey();
            }
        }
        public int GetGuess()
        {
            Console.WriteLine("Guess a Number: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("You must enter a number.");
            }
            return number;
        }
    }

    public enum Gamestate
    {
        Running,
        Wrong,
        Correct,
        Quit
    }
}
