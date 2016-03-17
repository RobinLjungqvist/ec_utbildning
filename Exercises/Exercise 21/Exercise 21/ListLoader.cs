using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    public class ListLoader
    {
        public List<LanguageData> ListOfLanguages;

        public ListLoader()
        {
            ListOfLanguages = LoadLanguageData();
        }

        private List<LanguageData> LoadLanguageData()
        {
            var templist = new List<LanguageData>();
            var reader = new StreamReader(@"LData.txt");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var input = line.Split('\t');

                var tempLD = new LanguageData(input[0], int.Parse(input[1]), input[2]);

                templist.Add(tempLD);


            }

            reader.Close();

            return templist;


        }
        public List<LanguageData> search(int min, int max)
        {
            var tempLanguageDataList = new List<LanguageData>();

            foreach (var Language in ListOfLanguages)
            {
                if (Language._Year >= min && Language._Year <= max)
                {
                    tempLanguageDataList.Add(Language);
                }

            }
            List<LanguageData> SortedByYear = tempLanguageDataList.OrderBy(languagedata => languagedata._Year).ToList();
            SaveSearchResult(SortedByYear);
            return SortedByYear;
        }
        private void SaveSearchResult(List<LanguageData> result)
        {
            var writer = new StreamWriter("SearchResult.txt");
            foreach (var DataObject in result)
            {
                writer.WriteLine("{0}\t{1}\t{2}", DataObject._Name, DataObject._Year, DataObject._Description);
                
            }
            writer.Close();

        }

        public List<LanguageData> GetListByYear()
        {
            return ListOfLanguages.OrderBy(x => x._Year).ToList();
        }


    }
}
