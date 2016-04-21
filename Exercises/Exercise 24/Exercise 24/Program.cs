using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            var myWeight = new Weight();

            myWeight.SetWeight(WeightUnit.Kilogram, 10);
            Console.WriteLine("10 kg in Pounds: " + myWeight.GetWeight(WeightUnit.Pound));
            myWeight.Add(WeightUnit.Kilogram, 10);
            Console.WriteLine("20 kg in Pounds: " + myWeight.GetWeight(WeightUnit.Pound));
            myWeight.SetWeight(WeightUnit.Pound, 10);
            Console.WriteLine("10 pounds in Kilogram: " + myWeight.GetWeight(WeightUnit.Kilogram));
            myWeight.SetWeight(WeightUnit.Kilogram, 1);
            Console.WriteLine("1kg in Ounces: " + myWeight.GetWeight(WeightUnit.Ounce));
            Console.WriteLine("1kg in Pounds: " + myWeight.GetWeight(WeightUnit.Pound));
            Console.WriteLine("1kg in grams: " + myWeight.GetWeight(WeightUnit.Gram));

            myWeight.SetWeight(WeightUnit.Ounce, 35.27);
            Console.WriteLine("35 ounces in Kilogram: " + myWeight.GetWeight(WeightUnit.Kilogram));


            Console.ReadKey();

        }
    }
}
