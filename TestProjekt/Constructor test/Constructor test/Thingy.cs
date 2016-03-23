using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_test
{
    class Thingy
    {
        
        List<Test> dataTest;

        public Thingy( List<Test> dataList)
        {
            
            dataTest = new List<Test>(dataList);
            dataList.ForEach(x => dataTest.Add(new Test(x.data1, x.data2)));
        }

        public Test GetList(int index)
        {
            return dataTest[index];
        }
        public void ChangeAValue()
        {
            dataTest[0].data1 = 5; 
        }
    }
}
