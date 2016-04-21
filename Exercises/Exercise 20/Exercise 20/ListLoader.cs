using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class ListLoader
    {
        List<string> LoadedList;
        public ListLoader()
        {
            LoadedList = new List<string>();
        }
        public void Load()
        {
            StreamReader reader = new StreamReader(@"languages.txt");

            string line;
            while((line = reader.ReadLine()) != null)
            {
                LoadedList.Add(line);
            }
            reader.Close();
        }
        public List<string> SearchFile(string input)
        {
            List<string> templist = new List<string>();

            foreach (var line in LoadedList)
            {
                if(line.ToLower().Contains(input.ToLower()))
                {
                    templist.Add(line);
                }
            }
            return templist;

        }
    }
}
