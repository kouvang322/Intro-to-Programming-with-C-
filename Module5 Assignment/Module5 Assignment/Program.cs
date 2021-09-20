using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            var vendingMachine = new Stack<string>();

            Console.WriteLine("Vending Machine");

            string usersChoiceOfAction = GetValidChoiceInput();

    
            while (usersChoiceOfAction != "E")

            {
                if (usersChoiceOfAction == "A")
                {
                    Console.WriteLine("What item would you like to add?");
                    string addItem = Console.ReadLine();
                    vendingMachine.Push(addItem);
                    usersChoiceOfAction = GetValidChoiceInput();
                }
                if (usersChoiceOfAction == "B")
                {
                    if (vendingMachine.Count == 0)
                    {
                        Console.WriteLine("There are no items in the vending machine.");
                        usersChoiceOfAction = GetValidChoiceInput();
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + vendingMachine.Pop());
                        usersChoiceOfAction = GetValidChoiceInput();
                    }
                }
            }

            Console.WriteLine("Thank you for using the vending machine!");
            Console.Read();
        }

        public static string GetValidChoiceInput()
        {
            Console.Write("Do you want to (A - Add Item, B - Buy Item, E - End): ");

            string userInput = Console.ReadLine().ToUpper();

            while (userInput.Length > 1 && userInput != "A" && userInput != "B" && userInput != "E")
            {
                Console.WriteLine("Please enter a letter that matches an availiable option.");
                Console.Write("Do you want to (A - Add Item, B - Buy Item, E - End): ");
                userInput = Console.ReadLine().ToUpper(); 
            }
            return userInput;
        }
    }
}
