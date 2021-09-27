using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Assignment
{
    class Program
    {
        public double totalSales = 0;
        static void Main(string[] args)
        {
            List<Item> vendItemList = new List<Item>();

            string stockItemName = GetValidEndItemInput();

            while (stockItemName != "NA")
            {
                int itemQuantityToStock = GetValidIntInput();

                double pricePerUnit = GetValidDoubleInput();

                Item vendingItem = new Item(stockItemName, itemQuantityToStock, pricePerUnit);

                vendItemList.Add(vendingItem);

                stockItemName = GetValidEndItemInput();
            }

            Console.WriteLine("#########################\n");

            Console.WriteLine("Vending Machine");

            for (int i = 0; i < vendItemList.Count; i++)
            {
                Item vendingMachineList = vendItemList[i];
                Console.WriteLine($"{ i + 1} {vendingMachineList.ToString()}");
            }

            double totalSalesCost = 0;
            int buyOption = GetValidItemBuyOption();

            while (buyOption != -1)
            {
                vendItemList[buyOption - 1].GetNewQuantity();

                totalSalesCost += vendItemList[buyOption - 1].GetPricePerUnit();

                buyOption = GetValidItemBuyOption();
            }

            Console.WriteLine("#########################\n");

            Console.WriteLine("Inventory in Vending Machine");

            for (int i = 0; i < vendItemList.Count; i++)
            {
                Item vendingMachineList = vendItemList[i];
                Console.WriteLine($"{vendItemList[i].GetQuantityInMachine()} {vendItemList[i].GetItem()}");
            }
            
            Console.WriteLine($"{totalSalesCost:c2} collected from sales");

            Console.Read();
        }

        public static string GetValidEndItemInput()
        {
            Console.Write("Item to stock (NA to end): ");

            string userInput = Console.ReadLine();

            if (userInput == "na")
            {
                userInput = userInput.ToUpper();
            }
            return userInput;
        }

        public static int GetValidIntInput()
        {
            Console.Write("Quantity: ");
            string userInput = (Console.ReadLine());

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Quantity: ");
                userInput = Console.ReadLine();
            }

            int quantityNumInput = Convert.ToInt32(userInput);

            return quantityNumInput;
        }

        public static double GetValidDoubleInput()
        {
            Console.Write("Price each: ");
            string userInput = (Console.ReadLine());

            while (!(double.TryParse(userInput, out double i)))
            {
                Console.WriteLine("Enter correct price");
                Console.Write("Price each: ");
                userInput = Console.ReadLine();
            }

            double priceNumInput = Convert.ToDouble(userInput);

            return priceNumInput;
        }


        public static int GetValidItemBuyOption()
        {
            Console.Write("Item to buy (NA to end): ");
            string userInput = (Console.ReadLine());

            if (userInput.ToLower() == "na")
            {
                userInput = userInput.ToUpper();
                return -1;
            }

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number that corresponds to an item in the vending machine.");
                Console.Write("Item to buy (NA to end): ");
                userInput = Console.ReadLine();
            }

            int quantityNumInput = Convert.ToInt32(userInput);

            return quantityNumInput;
        }
    }

}
