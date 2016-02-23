using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //Regex
using System.Threading.Tasks;
using System.IO;

namespace Binär_sökning
{
    class Program
    {
        static int BinarySearch(List<Person> listX, int x) // Metod för att söka i listan binärt.
        {
            int key = x;
            int first = 0;
            int last = listX.Count - 1;
            while (first <= last)
               {
                                int mid = ((first) + (last)) / 2;
                                if (key > listX[mid].PersonNr)
                                {
                                    first = mid + 1;
                                }
                                else if (key < listX[mid].PersonNr)
                                {
                                    last = mid - 1;
                                }
                                else
                                    return mid;
                            }
            return - 1;
        }
        static int StringSearch(List<Person> listX, string x)
        {
            for (int i = 0; i < listX.Count; i++)
            {
                if (listX[i].Name ==  x)
                {
                    return i;
                }
            }
            return -1;
        }
        static string[] SplitWords(string s)
        {
            return Regex.Split(s, @" ");
        }
        static void LoadList(List<Person> x)
        {
            StreamReader sr = new StreamReader("NummerLista.txt");
            string fileRow;
            while ((fileRow = sr.ReadLine()) != null)
            {
                string[] tempList = SplitWords(fileRow);
                int tempTal = Convert.ToInt32(tempList[1]);
                x.Add(new Person(tempList[0], tempTal));
            }
            sr.Close();
        }

        static void Main(string[] args)
        {
            List<Person> minLista = new List<Person>(); // Listan av klassen person som hanterar namn och personnummer.
            LoadList(minLista); // Laddarn in det som finns i text filen och skapar objekt av classen Person.
            //minLista.Add(new Person("ROBIN", 900618));
            //minLista.Add(new Person("ERIK", 890520)); // för att fylla på listan med lite namn för att testa så att det fungerade.
            //minLista.Add(new Person("ALBIN", 440206));
            //minLista.Add(new Person("RONNI", 640421));
            //minLista.Add(new Person("EMMA", 930929));
            bool loopCheck = false;
            do
            {
                try
                {
                    #region Bubblesort
                    int max = minLista.Count - 1;
                    for (int i = 0; i < minLista.Count; i++ )
                    {
                        int nrLeft = max - i;
                        for (int j = 0; j < nrLeft; j++)
                        {
                            if (minLista[j].PersonNr > minLista[j+1].PersonNr)
                            {
                                int temp = minLista[j].PersonNr;
                                minLista[j].PersonNr = minLista[j + 1].PersonNr;
                                minLista[j+1].PersonNr = temp;
                                string tempe = minLista[j].Name;
                                minLista[j].Name = minLista[j + 1].Name;
                                minLista[j + 1].Name = tempe;
                                
                            }
                        }
                    }
                    #endregion
                    #region Spara till fil
                    StreamWriter sw = new StreamWriter("NummerLista.txt");
                    foreach (Person element in minLista)
                    {
                        string temp = element.PersonNr.ToString();
                        sw.WriteLine(element.Name + " " + temp);
                        
                    }
                    sw.Close();
                    #endregion
                    Console.WriteLine("Välj handling i menyn: ");
                    Console.WriteLine("Sök efter [P]ersonnummer eller [N]amn.");
                    Console.WriteLine("[L]ägg till i listan");
                    Console.WriteLine("[T]a bort ifrån listan");
                    Console.WriteLine("[V]isa lista");
                    Console.WriteLine("[A]vsluta");
                    string str = Console.ReadLine();
                    string input = str.ToUpper();
                    switch (input)
                    {
                        case "P": // Binär sökning
                            {
                                Console.WriteLine("Ange personnummer:");
                                string searchInput = Console.ReadLine();
                                int searchIntput = Convert.ToInt32(searchInput);
                                int binS = BinarySearch(minLista, searchIntput);
                                if (binS >= 0)
                                {
                                    Console.WriteLine("Person numret finns på index {0} och tillhör {1}.", binS + 1, minLista[binS].Name);
                                }
                                else
                                {
                                    Console.WriteLine("Det finns inget med det personnummret i listan.");
                                }
                            }
                            break;
                        case "N":
                            Console.WriteLine("Ange ett namn:");
                            string inputNamn = Console.ReadLine().ToUpper();
                            int strTest = StringSearch(minLista, inputNamn);
                            if (strTest >= 0)
                                Console.WriteLine("{0} har personnummer {1} och finns på index {2}", inputNamn, minLista[strTest].PersonNr, strTest + 1);
                            else
                            {
                                Console.WriteLine("Kunde inte hittan en person med det namnet.");
                            }
                            break;
                        case "L": // Lägger till person i listan.
                            {
                                Console.WriteLine("Skriv in ett namn:");
                                string newName = Console.ReadLine().ToUpper();
                                Console.WriteLine("Skriv in tillhörande personnummer:");
                                string strPN = Console.ReadLine();
                                int newPersonnummer = Convert.ToInt32(strPN);
                                minLista.Add(new Person(newName, newPersonnummer));
                                Console.WriteLine("Personen har blivit tillagd.");

                            }
                            break;
                        case "T": // Tar bort person ifrån listan.
                            {
                                for (int i = 0; i < minLista.Count; i++ )
                                {
                                    Console.WriteLine("Index {0}: {1} {2}", (i + 1) , minLista[i].Name, minLista[i].PersonNr);
                                }
                                
                                Console.WriteLine("Ange index för den du vill ta bort:");
                                string remStr = Console.ReadLine();
                                int remInput = Convert.ToInt32(remStr) - 1;
                                if (remInput >= 0 && remInput <= minLista.Count)
                                {
                                    minLista.RemoveAt(remInput);
                                    Console.WriteLine("Information på index {0} borttaget.", remInput + 1);
                                }
                                else
                                {
                                    Console.WriteLine("Angett värde utan för index.");
                                }
                            }
                            break;
                        case "V": // Visa listan aka Hämta ifrån fil.
                            {
                                StreamReader sr = new StreamReader("NummerLista.txt");
                                string fileRow;
                                while ((fileRow = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(fileRow);
                                    
                                }
                                sr.Close();
                            }
                            break;
                        case "A": // avslutar programmet.
                            {
                                loopCheck = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Fel input.");
                            break;
                    }
                    Console.ReadLine(); // så att man hinner läsa vad som händer i switcharna.
                    Console.Clear();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (loopCheck == false);
        }

    }
}
