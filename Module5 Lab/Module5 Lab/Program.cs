using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numUFOSightings = new int[5];
            string[] dayOfUFOSightings = new string[5];


            numUFOSightings[0] = GetValidInputMonNum();
            numUFOSightings[1] = GetValidInputTuesNum();
            numUFOSightings[2] = GetValidInputWedNum();
            numUFOSightings[3] = GetValidInputThurNum();
            numUFOSightings[4] = GetValidInputFriNum();

            dayOfUFOSightings[0] = "Monday";
            dayOfUFOSightings[1] = "Tueday";
            dayOfUFOSightings[2] = "Wednesday";
            dayOfUFOSightings[3] = "Thursday";
            dayOfUFOSightings[4] = "Friday";




            Array.Sort(numUFOSightings, dayOfUFOSightings);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dayOfUFOSightings[i] + " " + numUFOSightings[i]);
            }

            Console.Read();
        }

        public static int GetValidInputMonNum()
        {
            Console.Write("Enter sightings on Monday: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Enter sightings on Monday: ");
                userInput = Console.ReadLine();
            }

            int monSightingsInput = Convert.ToInt32(userInput);

            return monSightingsInput;
        }

        public static int GetValidInputTuesNum()
        {
            Console.Write("Enter sightings on Tuesday: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Enter sightings on Tuesday: ");
                userInput = Console.ReadLine();
            }

            int tuesSightingsInput = Convert.ToInt32(userInput);

            return tuesSightingsInput;
        }

        public static int GetValidInputWedNum()
        {
            Console.Write("Enter sightings on Wednesday: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Enter sightings on Wednesday: ");
                userInput = Console.ReadLine();
            }

            int wedSightingsInput = Convert.ToInt32(userInput);

            return wedSightingsInput;
        }

        public static int GetValidInputThurNum()
        {
            Console.Write("Enter sightings on Thursday: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Enter sightings on Thursday: ");
                userInput = Console.ReadLine();
            }

            int thurSightingsInput = Convert.ToInt32(userInput);

            return thurSightingsInput;
        }

        public static int GetValidInputFriNum()
        {
            Console.Write("Enter sightings on Friday: ");

            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("Enter sightings on Friday: ");
                userInput = Console.ReadLine();
            }

            int friSightingsInput = Convert.ToInt32(userInput);

            return friSightingsInput;
        }
    }
}
