using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class ListLoader
    {
        List<LanguageData> ListOfLanguages;

        public ListLoader()
        {
            ListOfLanguages = new List<LanguageData>();
            Load();
        }

        private void Load()
        {

            var reader = new StreamReader(@"LData.txt");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var input = line.Split('\t');

                var tempLD = new LanguageData(input[0], int.Parse(input[1]), input[2]);

                ListOfLanguages.Add(tempLD);


            }

            reader.Close();


        }
        public List<LanguageData> search(int min, int max)
        {
            var tempLanguageDataList = new List<LanguageData>();

            foreach (var Language in ListOfLanguages)
            {
                if (Language._Year > min && Language._Year < max)
                {
                    tempLanguageDataList.Add(Language);
                }

            }
            List<LanguageData> SortedByYear = tempLanguageDataList.OrderBy(languagedata => languagedata._Year).ToList();
            return SortedByYear;
        }


    }
}
