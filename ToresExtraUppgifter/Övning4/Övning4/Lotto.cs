using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    class Lotto
    {
        Random rnd = new Random();

        public List<int> DrawSevenRandomNumbers()
        {
            var tempList = new List<int>();
            while (tempList.Count < 7)
            {
                bool flag = false;
                int tempnr = rnd.Next(1, 36);
                if (tempList.Count < 1)
                    tempList.Add(tempnr);
                else
                {
                    foreach (var item in tempList)
                    {
                        if (item == tempnr)
                            flag = true;
                        
                    }
                    if (flag == false)
                        tempList.Add(tempnr);
                }

            }
            return tempList;
        }

        public void printLottoNumbers(List<int> numberList)
        {
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
