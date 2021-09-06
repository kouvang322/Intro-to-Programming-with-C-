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
            int userEnteredDays;
            int userEnteredMinutes;

            Console.Write("How many days will you be traveling? ");
            string daysTravel = (Console.ReadLine());

            int.TryParse(daysTravel, out userEnteredDays);

            if (int.TryParse(daysTravel, out userEnteredDays) == false)
            {
                Console.Write("Please enter number of days you will be traveling. ");
                Console.Read();
            }
            else
            {
                Console.WriteLine("How many minutes per day will you use? ");
                string useMinutes = (Console.ReadLine());
                
                int.TryParse(useMinutes, out userEnteredMinutes);

                if (int.TryParse(useMinutes, out userEnteredMinutes) == false)
                {
                    Console.Write("Please enter how many minutes you will use per day. ");
                    Console.Read();
                }
                else
                {
                double bigDayPass = BigDayPrice(userEnteredDays);
                double touristPass = TouristPassPrice(userEnteredMinutes, userEnteredDays);
                double adventurePass = CalculateAdventureMinutesPackage(userEnteredMinutes, userEnteredDays);

                Console.WriteLine($"The Big Day Pass would cost you {bigDayPass:c2}");
                Console.WriteLine($"The Tourist Pass would cost you {touristPass:c2}");
                Console.WriteLine($"The Adventure Pass would cost you {adventurePass:c2}");

                //At the end of the program we want to see this

                Console.WriteLine(CalculateBestPrice(bigDayPass, touristPass, adventurePass));

                Console.Read();

                }
            }
        }

        // calculate Big Day pass : $10 per day, unlimited minutes
        static int BigDayPrice(int days)
        {
            return 10 * days;
        }

        // calculate Tourist pass : $0.20 per minute
        static double TouristPassPrice(int minutes, int days)
        {
            return .20 * (days * minutes);
        }

        //The Adventurer Pass: $3 per day and $0.10 per minute
        static double CalculateAdventureMinutesPackage(int minutes, int days)
        {
            return (.10 * (days * minutes)) + (3 * days);
        }

        static string CalculateBestPrice(double bDP, double tP, double aP)
        {
            double cheapestPrice = 0;
            string cheapestPackage = "";
            //lets assume that at the end of our magic logic, we get the lowest number. 

            if (bDP == tP)
            {
                cheapestPrice = bDP;
                cheapestPackage = "Big Day Pass or Tourist Pass";
            }

            if (bDP == aP)
            {
                cheapestPrice = bDP;
                cheapestPackage = "Big Day Pass or Adventure Pass";
            }

            if (aP == tP)
            {
                cheapestPrice = aP;
                cheapestPackage = "Tourist Pass or Adventure";
            }

            if (bDP < tP && bDP < aP)
            {
                cheapestPrice = bDP;
                cheapestPackage = "Big Day Pass";
            }
            if (tP < bDP && tP < aP)
            {
                cheapestPrice = tP;
                cheapestPackage = "Tourist Pass";
            }
            if (aP < bDP && aP < tP)
            {
                cheapestPrice = aP;
                cheapestPackage = "Adventure Pass";
            }
            return "You should purchase " + cheapestPackage + " for " + cheapestPrice.ToString("C2");
        }
    }
}
