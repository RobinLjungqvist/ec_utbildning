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
            VD.PrintVehicle(Volvo);
            VD.PrintVehicle(Segelbåt);
            Console.ReadKey();
        }
    }
}
