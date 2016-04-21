using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_test
{
    class Test
    {
        public int data1 { get; set; }
        public int data2 { get; set; }

        public Test(int one, int two)
        {
            data1 = one;
            data2 = two;
        }

    }
}
