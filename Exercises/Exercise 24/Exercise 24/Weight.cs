using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24
{
    class Weight
    {
        private Dictionary<WeightUnit, double> WeightConversion;
        private double weightInKg = 0;

        public Weight()
        {
            WeightConversion = new Dictionary<WeightUnit, double>()
            {
                [WeightUnit.Kilogram] = 1.0,
                [WeightUnit.Pound] = 2.2046226218,
                [WeightUnit.Gram] = 1000,
                [WeightUnit.Ounce] = 35.2739619
            };

        }
            

        public void SetWeight(WeightUnit unit, double amount)
        {
            weightInKg = amount / WeightConversion[unit];
            
        }
        public double GetWeight(WeightUnit unit)
        {
            return weightInKg * WeightConversion[unit];
        }
        public void Add(WeightUnit unit, double amount)
        {
            weightInKg += amount / WeightConversion[unit];
        }
    }
}
