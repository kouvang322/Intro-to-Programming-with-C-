using System;

namespace Module1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many Monsters did you drink today? ");
            int monsterQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You consumed:");

            int calories = 220 * monsterQty;
            int suger = 54 * monsterQty;
            int caffine = 160 * monsterQty;

            Console.WriteLine(calories + " Calories");
            Console.WriteLine(suger + " Suger");
            Console.WriteLine(caffine + "mg Caffine");
            Console.WriteLine("Press any key to continue....");
        }
    }
}
