using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._3
{
    class Car
    {
        public Gear thisGear = new Gear();
        public Engine thisEngine = new Engine();
        private string model = string.Empty;

        public Car (string model)
        {
            this.model = model;
        }
        public Car()
        {

        }
        public string GetModel()
        {
            return this.model;
        }
        public void StoreModel(string input)
        {
            this.model = input;
        }
    }
}
