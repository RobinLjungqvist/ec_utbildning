using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something in swedish.");
            var userInput = Console.ReadLine();
            Console.WriteLine("This text is now good for english systems.");
            Console.WriteLine(EnglishText(userInput));
            Console.ReadKey();
        }

        public static string EnglishText(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in input)
            {
                switch(letter)
                {
                    case ('å'):
                        sb.Append("aa");
                        break;
                    case ('Å'):
                        sb.Append("Aa");
                        break;
                    case 'ä':
                        sb.Append("ae");
                        break;
                    case 'Ä':
                        sb.Append("Ae");
                        break;
                    case 'ö':
                        sb.Append("oo");
                        break;
                    case 'Ö':
                        sb.Append("Oo");
                        break;
                    default:
                        sb.Append(letter);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}
