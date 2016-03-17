using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class LanguageData
    {
        public string _Name { get; }
        public int _Year { get; }
        public string _Description { get; }

        public LanguageData(string name, int year, string description)
        {
            _Name = name;
            _Year = year;
            _Description = description;
        }
    }
}
