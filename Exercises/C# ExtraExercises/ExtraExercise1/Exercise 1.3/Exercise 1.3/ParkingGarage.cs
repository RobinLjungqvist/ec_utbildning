using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1._3
{
    class ParkingGarage
    {
        public Car[] ParkingSlots = new Car[10];
        public void ParkCar(int parkSlot, Car CarToCarpark)
        {
            if(ParkingSlots[parkSlot] == null && parkSlot <= 9 && parkSlot >= 0)
            {
                
                ParkingSlots[parkSlot] = CarToCarpark;
                Billing newBill = new Billing();
                newBill.CarParked(CarToCarpark);
                Console.WriteLine($"You have parked your car at parking slot nr: {parkSlot}");

            }
            else if (!(ParkingSlots[parkSlot] == null))
            {
                Console.WriteLine("The parkingslot is occupied.");
            }
            else
            {
                Console.WriteLine("There's only parking slots between 0 - 9.");
            }
        }
        public Car GetCar(int parkSlot)
        {
            if (!(ParkingSlots[parkSlot] == null))
            {
                Console.WriteLine($"You have got your {ParkingSlots[parkSlot].GetModel()}.");
            }
            else
            {
                Console.WriteLine("The parking spot is empty, there's no car to get.");
            }
            return ParkingSlots[parkSlot];
           
        }
        public void ListAllCars()
        {
            foreach (Car item in ParkingSlots)
            {
                Console.WriteLine(item.GetModel());
            }
        }
    }
}
