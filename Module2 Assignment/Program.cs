using System;

namespace Module2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is anyone attending the party a vegetarian? (y/n) ");
            string isVeggie = (Console.ReadLine());

            //  Confirming if correct information was entered for first question

            if (isVeggie == "y" || isVeggie == "n")
            {
                Console.Write("Is anyone attending the party a vegan? (y/n) ");
                string isVegan = (Console.ReadLine());
                
                // Confirming correct information for second question

                if (isVegan == "y" || isVegan == "n")
                {
                    Console.Write("Is anyone attending the party gluten free? (y/n) ");
                    string isGlutenFree = (Console.ReadLine());

                    // Confirming correct information for final question

                    if (isGlutenFree == "y" || isGlutenFree == "n")
                    {

                        // Options given depending on answers 

                        if  ((isVeggie == "y" && isVegan == "y" && isGlutenFree == "y")||
                            (isVeggie == "y" && isVegan == "y" && isGlutenFree == "n")||
                            (isVeggie == "n" && isVegan == "y" && isGlutenFree == "y")||
                            (isVeggie == "n" && isVegan == "y" && isGlutenFree == "n"))
                        {
                            //  Restricted to these two

                            Console.WriteLine("You may order from the following restaurants:");
                            Console.WriteLine("Cafe Manna");
                            Console.WriteLine("Harvest Cafe");
                        }
                        else if ((isVeggie == "y" && isVegan == "n" && isGlutenFree == "y")||
                                (isVeggie == "n" && isVegan == "n" && isGlutenFree == "y"))
                        {
                            //  Can still order even though don't need to accommodate vegans

                            Console.WriteLine("You may order from the following restaurants:");
                            Console.WriteLine("Marco's Pizza");
                            Console.WriteLine("Cafe Manna");
                            Console.WriteLine("Harvest Cafe");
                        }
                        else if (isVeggie == "y" && isVegan == "n" && isGlutenFree == "n")
                        {
                            //  Four places can still accommodate vegetarians

                            Console.WriteLine("You may order from the following restaurants:");
                            Console.WriteLine("Marco's Pizza");
                            Console.WriteLine("Cafe Manna");
                            Console.WriteLine("India Kitchen");
                            Console.WriteLine("Harvest Cafe");
                        }
                        else if (isVeggie == "n" && isVegan == "n" && isGlutenFree == "n")
                        {
                            // No restrictions for attendees

                            Console.WriteLine("You may order from the following restaurants:");
                            Console.WriteLine("Thunder Bay Grill");
                            Console.WriteLine("Marco's Pizza");
                            Console.WriteLine("Cafe Manna");
                            Console.WriteLine("India Kitchen");
                            Console.WriteLine("Harvest Cafe");
                        }
                        else
                        {
                            // Results from other combinations besides options given, just in case

                            Console.WriteLine("Sorry, there are no restaurants to accommodate attendees");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter y or n");
                    }
                }
                 else
                 {
                    Console.WriteLine("Please enter y or n");
                 }
            }
            else
            {
                Console.WriteLine("Please enter y or n");
            }
        }
    }
}
