using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataList = new List<Test>();

            var one = new Test(1, 1);
            var two = new Test(2,2);

            dataList.Add(one);
            dataList.Add(two);

            var thing = new Thingy(dataList);

            thing.ChangeAValue();

            Console.WriteLine("MasterList: Changed value:");
            Console.WriteLine(dataList[0].data1);
            Console.WriteLine("Copiedlist:");
            Console.WriteLine(thing.GetList(0).data1);

            double ost = 5.2;

            int ostboll = Convert.ToInt32(ost);

            Console.ReadKey();
        }
    }
}
