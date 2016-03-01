using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> lista = new List<Vehicle>();
            Car Volvo = new Car("bil", 4);
            Boat Segelbåt = new Boat("Båt", 2);
            lista.Add(Volvo);
            lista.Add(Segelbåt);

            foreach (var item in lista)
            {
                item.print();
            }
            Console.ReadKey();


        }
    }
    abstract class Vehicle
    {
        public string vehicleType = "";

        public Vehicle(string vehicleT)
        {
            this.vehicleType = vehicleT;
        }
        public virtual void print()
        {
            Console.WriteLine(this.vehicleType + " :");

        }
    }
    class Car:Vehicle
    {
        public int nrofD;
        public Car(string vechiletype, int nrOfDoors): base (vechiletype)
        {
            this.nrofD = nrOfDoors;
        }
        public override void print()
        {
            base.print();
            Console.Write(nrofD);
            
        }

    }
    class Boat : Vehicle
    {
        public int nrofSails;
        public Boat(string vechiletype, int nrOfSails) : base(vechiletype)
        {
            this.nrofSails  = nrOfSails;
        }

    }


}
