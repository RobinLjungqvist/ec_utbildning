using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData VD = new VehicleData();
            Car Volvo = new Car();
            Boat Segelbåt = new Boat(nrOfSails: 4);
            var list = new List<Vehicle>();
            list.Add(Volvo);
            list.Add(Segelbåt);
            foreach (var item in list)
            {
                if (item is Car)
                {
                    var myCar = (Car)item;
                    VD.PrintVehicle(myCar);
                }
                if (item is Boat)
                {
                    var myBoat = (Boat)item;
                    VD.PrintVehicle(myBoat);
                }
            }
            Console.ReadKey();
        }
    }
}
