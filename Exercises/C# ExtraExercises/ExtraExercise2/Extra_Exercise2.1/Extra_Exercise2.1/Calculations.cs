using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise2._1
{
    class Calculations
    {
        public int SmallestNR(int[] inputList)
        {
            int smallestNumber = 0;
            for (int i = 0; i < inputList.Length; i++)
            {
                if (smallestNumber == 0)
                {
                    smallestNumber = inputList[i];
                }
                for (int j = 0; j < inputList.Length; j++)
                {
                    if(inputList[i] < inputList[j] && inputList[i] <= smallestNumber)
                    {
                        smallestNumber = inputList[i];
                    }
                }
            }
            return smallestNumber;
        }
        public int BiggestNR(int[] inputList)
        {
            int BiggestNumber = 0;
            for (int i = 0; i < inputList.Length; i++)
            {
                if (BiggestNumber == 0)
                {
                    BiggestNumber = inputList[i];
                }
                for (int j = 0; j < inputList.Length; j++)
                {
                    if (inputList[i] > inputList[j] && inputList[i] >= BiggestNumber)
                    {
                        BiggestNumber = inputList[i];
                    }
                }
            }
            return BiggestNumber;
        }
        public int AverageValue(int[] inputList)
        {
            int sum = 0;
            foreach (var item in inputList)
            {
                sum += item;
            }
            return sum / inputList.Length;
        }
    }
}
