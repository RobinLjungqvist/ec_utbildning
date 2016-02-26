using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MinVolvo = new Car("Volvo V70");
            Console.WriteLine($"You have a {MinVolvo.GetModel()}.");
            MinVolvo.thisEngine.StartEngine(MinVolvo.thisGear.CurrentGear);
            MinVolvo.thisEngine.StartEngine(MinVolvo.thisGear.CurrentGear);
            ParkingGarage MittGarage = new ParkingGarage();
            MittGarage.ParkCar(2, MinVolvo);
            MittGarage.GetCar(1);
            MittGarage.GetCar(2);
            Console.ReadKey();
        }
    }
}
