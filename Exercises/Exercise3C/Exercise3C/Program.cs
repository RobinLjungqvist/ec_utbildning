using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3C
{

    class Program
    {
        public static bool FoodType()
        {
            Console.WriteLine("Is the item a food item? y/n ");
            ConsoleKeyInfo key;
            var choice = Console.ReadKey(true);
            if (choice.KeyChar == 'y')
            {
                return true;
            }
            else if (choice.KeyChar == 'n')
            {
                return false;
            }
            else
            {
                Console.WriteLine("Answer with [y]es or [n]o.");
                FoodType();
            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter your products name:");
            string productName = Console.ReadLine();

            Console.Write("Enter the price of the product:");
            int pricePerUnit;
            while (!int.TryParse(Console.ReadLine(), out pricePerUnit));

            Console.Write("Enter the number of products being bought:");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity));

            bool fooditem = FoodType();

            double tax = 1.25;
            if (fooditem == true)
            {
                tax = 1.1;
            }

            double cost = pricePerUnit * quantity;
            string receipt = string.Format("Product: {0}\r\nAmount: {1}\r\nCost excluding tax: {2}\r\nCost including tax: {3}\r\nTax amount: {4}",
                                            productName, quantity, cost, (cost * tax), (cost * tax) - cost);

            Console.WriteLine(receipt);
            Console.ReadLine();
        }
    }
}
