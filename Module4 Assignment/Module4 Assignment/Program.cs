using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = GetValidInputStartNum();

            int endingNum = GetValidInputEndingNum();

            bool userInputsAreCorrect = determineIfValuesAreCorrect(startNum, endingNum);

            while (!userInputsAreCorrect)
            {
                //We need to change the ending number
                Console.Write("Ending number has to be more than starting number - ");
                endingNum = GetValidInputEndingNum();

                //Do another check
                if (startNum < endingNum)
                {
                    userInputsAreCorrect = true;
                    //break out of while if true
                }
            }

            //Now that we have good values can focus on the logic portion

            int evenNumCount = CalculateNumberOfEvens(startNum, endingNum);
            int oddNumCount = CalculateNumberOfOdds(startNum, endingNum);

            CompletedCountOfEvenAndOddNums(evenNumCount, oddNumCount);

            Console.Read();
        }

        public static int GetValidInputStartNum()
        {
            Console.Write("Starting number: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.WriteLine("Starting number: ");
                userInput = Console.ReadLine();
            }

            int startNumInput = Convert.ToInt32(userInput);

            return startNumInput;
        }

        public static int GetValidInputEndingNum()
        {
            Console.Write("Ending number: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.WriteLine("Starting number: ");

                userInput = Console.ReadLine();
            }

            int endingNumInput = Convert.ToInt32(userInput);

            return endingNumInput;
        }

        public static void CompletedCountOfEvenAndOddNums(int evenCount, int oddCount)
        {
            Console.WriteLine("Number of even numbers: " + evenCount);
            Console.WriteLine("Number of odd numbers: " + oddCount);
        }

        public static int CalculateNumberOfEvens(int start, int ending)
        {
            int evenCount = 0;

            for (int i = start; i <= ending; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                }
            }
            return evenCount;
        }

        public static int CalculateNumberOfOdds(int start, int ending)
        {
            int oddCount = 0;

            for (int i = start; i <= ending; i++)
            {
                if (i % 2 == 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }

        public static bool determineIfValuesAreCorrect(int startNum, int endNum)
        {
            bool result = (startNum <= endNum);
            return result;
        }
    }
}

// No need to pay attention to this, simply remembering my initial attempt
//First attempt trying to solve, misinterpreted question
//public static void StartIsHigherThanEndingError(int start, int ending, int evenCount, int oddCount)
//{
//    bool startNumIsHigher = (start >= ending);

//    while (startNumIsHigher)
//    {
//        if(start % 2 == 0 || ending % 2 == 0 )  //10
//        {
//            evenCount++;
//        } 
//        if(ending % 2 != 0 || start % 2 != 0)   //8
//        {
//            oddCount++;
//        }

//        Console.WriteLine("Starting number: " + start);
//        Console.WriteLine("Ending number: " + ending);
//        Console.WriteLine("Ending number has to be more than starting number - Ending number: " + start);
//        Console.WriteLine("Ending number has to be more than starting number - Ending number: " + (start + 1));
//        Console.WriteLine("Number of even numbers: " + evenCount);
//        Console.WriteLine("Number of odd numbers: " + oddCount);

//        int endingNum = GetValidInputEndingNum();

//        if (endingNum > start)
//        {
//            startNumIsHigher = false;
//        }
//    }
//}
