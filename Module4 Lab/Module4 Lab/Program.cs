using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Calculator");
            Console.WriteLine("------------------");
            Console.Write("Enter the number of days worked> ");

            ValidateUserInput();
            
        }

        public static void ValidateUserInput()
        {
            bool userInputError = true;
            bool userInputIsValid = true;
            string userInput;
            int userDaysWorkedEntered;
            do
            {
                userInput = Console.ReadLine();
                userInputIsValid = int.TryParse(userInput, out int x);

                if (userInputIsValid)
                {
                    userInputError = false;
                    userDaysWorkedEntered = Convert.ToInt32(userInput);

                    int currentDaysWorked = 1;

                    int penniesEarned = 1;

                    double totalEarned = 0;

                    while (userDaysWorkedEntered == 0)
                    {
                        Console.WriteLine("Days worked can not be zero. Enter 1,2,3....");
                        userDaysWorkedEntered = Convert.ToInt32(Console.ReadLine());
                    }
                    do
                    {
                        Console.WriteLine("Pennies earned on day " + currentDaysWorked + " : " + penniesEarned);
                        totalEarned += penniesEarned;
                        penniesEarned *= 2;
                        currentDaysWorked++;
                    }while (currentDaysWorked <= userDaysWorkedEntered);

                    Console.WriteLine($"Total: {totalEarned / 100:c2}");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Please enter a number for days worked. Ex 1,2,3....");
                    userInputError = true;
                }
            } while (userInputError);
        }
    }
}