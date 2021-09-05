using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many days will you be traveling? ");
            int daysTravel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many minutes per day will you use? ");
            int useMinutes = Convert.ToInt32(Console.ReadLine());

            double bigDayPass = bigDayPrice(daysTravel);
            double touristPass = touristPassPrice(useMinutes, daysTravel);
            double adventurePass = calculateAdventureMinutesPackage(useMinutes, daysTravel);

            Console.WriteLine($"The Big Day Pass would cost you {bigDayPass:c2}");
            Console.WriteLine($"The Tourist Pass would cost you {touristPass:c2}");
            Console.WriteLine($"The Adventure Pass would cost you {adventurePass:c2}");

            //At the end of the program we want to see this

            Console.WriteLine(calculateBestPrice(bigDayPass, touristPass, adventurePass));

            Console.Read();
        }

        // calculate Big Day pass : $10 per day, unlimited minutes
        static int bigDayPrice(int days)
        {
            return 10 * days;
        }

        // calculate Tourist pass : $0.20 per minute
        static double touristPassPrice(int minutes, int days)
        {
            return .20 * (days * minutes);
        }

        //The Adventurer Pass: $3 per day and $0.10 per minute
        static double calculateAdventureMinutesPackage(int minutes, int days)
        {
            return (.10 * (days * minutes)) + (3 * days);
        }

        static string calculateBestPrice(double bDP, double tP, double aP)
        {
            double cheapestPrice = 0;
            string cheapestPackage = "";
            //lets assume that at the end of our magic logic, we get the lowest number. 

            if (bDP < tP && bDP < aP)
            {
                cheapestPrice = bDP;
                cheapestPackage = "Big Day Pass";
            }
            else if (tP < bDP && tP < aP)
            {
                cheapestPrice = tP;
                cheapestPackage = "Tourist Pass";
            }
            else if (aP < bDP && aP < tP)
            {
                cheapestPrice = aP;
                cheapestPackage = "Adventure Pass";
            }
            return "You should purchase " + cheapestPackage + " for " + cheapestPrice.ToString("C2");
        }
    }
}
