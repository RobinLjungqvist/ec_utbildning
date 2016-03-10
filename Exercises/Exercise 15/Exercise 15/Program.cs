using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var Print = new PrintStuff();
            var Altereration = new Alterations();
            var input = "Hello World!";

            var dict = Altereration.StringToCharDictionary(input);
            Print.PrintDictionary(dict);

            Console.WriteLine("---------------------------------");

            var newInput = Altereration.RemoveSymbolsThatIsntLetters(input);
            var newDict = Altereration.StringToCharDictionary(newInput);
            Print.PrintDictionary(newDict);

            Console.WriteLine("---------------------------------");
            var sentenceInput = "Det var det faktiskt visst det! Och det måste du tro att det var!";
            var newDict2 = Altereration.SentenceToWordsDictionary(sentenceInput);
            Print.PrintDictionary(newDict2);

            Console.WriteLine("---------------------------------");


            Console.ReadKey();
        }
    }
    public class Alterations
    {
        public Dictionary<char,int> StringToCharDictionary(string input)
        {
            var dict = new Dictionary<char, int>();

            foreach (var character in input)
            {
                dict[character] = 0;
            }

            foreach (var character in input)
            {
                if (dict.ContainsKey(character))
                {
                    dict[character] += 1;
                }
            }

            return dict;
        }
        public Dictionary<string, int> SentenceToWordsDictionary(string input)
        {
            var dict = new Dictionary<string, int>();
            var wordArray = input.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                wordArray[i] = RemoveSymbolsThatIsntLetters(wordArray[i]).ToLower();
            }
            foreach (var word in wordArray)
            {
                dict[word] = 0;
            }
            foreach (var word in wordArray)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
            }
            return dict;
        }

        public string RemoveSymbolsThatIsntLetters(string input)
        {
            string temp = string.Empty;
            foreach (var item in input)
            {
                if(Char.IsLetter(item))
                {
                    temp += item;
                }
            }
            return temp;
        }
    }
    public class PrintStuff
    {
        public void PrintDictionary(Dictionary<char,int> dict)
        {
            foreach (var key in dict)
            {
                var numberOfOccurances = string.Empty;
                for (int i = 0; i < key.Value; i++)
                {
                    numberOfOccurances += "* ";
                }
                var output = string.Format($"{key.Key} : {numberOfOccurances}");
                Console.WriteLine(output);
            }

        }

        public void PrintDictionary(Dictionary<string,int> dict)
        {
            foreach (var key in dict)
            {
                var numberOfOccurances = string.Empty;
                for (int i = 0; i < key.Value; i++)
                {
                    numberOfOccurances += "* ";
                }
                var output = string.Format($"{key.Key} : {numberOfOccurances}");
                Console.WriteLine(output);
            }
        }
    }
}
