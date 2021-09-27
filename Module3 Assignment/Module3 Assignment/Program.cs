using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userFailedToEnterCorrectInput = false;

            do
            {
                int userInputDays;

                Console.WriteLine("How many days did you exceed 10,000 steps? ");
                string daysStepGoalExceeded = Console.ReadLine();

                bool userInputIsValid = int.TryParse(daysStepGoalExceeded, out userInputDays);

                if (!userInputIsValid)
                {
                    Console.WriteLine("Please enter number of days you exceeded 10,000 steps");
                    Console.WriteLine("Enter numbers only.");
                    userFailedToEnterCorrectInput = true;
                }
                else
                {
                    //Points earned from days were user exceeded 10,000 steps
                    int daysStepGoalPoints = DaysStepsExceededPoints(userInputDays);
                    Console.WriteLine("You earned " + daysStepGoalPoints + " points from step goals");
                    
                    
                    //Points earned from yoga classes
                    Console.WriteLine("How many yoga classes did you attend? ");
                    string yogaClassesAttended = (Console.ReadLine());

                    userInputIsValid = int.TryParse(yogaClassesAttended, out int x);

                    if (!userInputIsValid) 
                    {
                        Console.WriteLine("you need to enter a number for classes attended.");
                        userFailedToEnterCorrectInput = true;
                    }
                    else
                    {
                        int yogaPoints = YogaClassPoints(Convert.ToInt32(yogaClassesAttended));
                        Console.WriteLine("You earned " + yogaPoints + " points from yoga classes");

                        Console.WriteLine("How many aerobics classes did you attend? ");
                        string aerobicsClassesAttended = (Console.ReadLine());
                        userInputIsValid = int.TryParse(aerobicsClassesAttended, out int y);

                        if(!userInputIsValid)
                        {
                            Console.WriteLine("you need to enter a number for classes attended.");
                            userFailedToEnterCorrectInput = true;
                        }
                        else 
                        {
                            //Points earned from aerobic classes
                            int aerobicsPoints = AerobicsClassPoints(Convert.ToInt32(aerobicsClassesAttended));
                            Console.WriteLine("You earned " + aerobicsPoints + " points from aerobics classes");


                            Console.WriteLine("How many weekly nutrition meetings did you attend? ");
                            string nutritionMeetingsAttended = (Console.ReadLine());

                            userInputIsValid = int.TryParse(nutritionMeetingsAttended, out int z);

                            if(!userInputIsValid)
                            {
                                Console.WriteLine("you need to enter a number for meeting attended.");
                                userFailedToEnterCorrectInput = true;
                            }
                            else
                            {

                                //Points earned from nutrition meetings 
                                int nutritionPoints = NutritionMeetingPoints(Convert.ToInt32(nutritionMeetingsAttended));
                                Console.WriteLine("You earned " + nutritionPoints + " points from aerobics classes");

                                //Calculating how many points user earned in the month
                                int monthlyPointsEarned = daysStepGoalPoints + yogaPoints + aerobicsPoints + nutritionPoints;

                                //Calculating how many Amazons were earned by the user
                                int amazonCardsEarned = monthlyPointsEarned / 50;
                                Console.WriteLine("You earned " + monthlyPointsEarned + " this month, so that means you earned " + amazonCardsEarned + " Amazon gift cards.");
                            }
                        }
                    }

                }
            } while (userFailedToEnterCorrectInput);


            Console.Read();
        }
        //Caluculating points from exceeding steps per day
        static int DaysStepsExceededPoints(int days)
        {
            return days * 5;
        }

        //Caluculating points from yoga classes attended
        static int YogaClassPoints(int yogaClass)
        {
            int yogaPoints = 0;

            if (yogaClass >= 6 && yogaClass < 12)
            {
                yogaPoints = 10;
            }
            else if (yogaClass >= 12)
            {
                yogaPoints = 30;
            }
            return yogaPoints;
        }


        //Caluculating points from aerobics classes attended
        static int AerobicsClassPoints(int aerobicsClass)
        {
            int aerobicsPoints = 0;

            if (aerobicsClass >= 6 && aerobicsClass < 12)
            {
                aerobicsPoints = 20;
            }
            else if (aerobicsClass >= 12)
            {
                aerobicsPoints = 50;
            }
            return aerobicsPoints;
        }

        //Caluculating points from nutrition meetings attended
        static int NutritionMeetingPoints(int nutritionMeetings)
        {
            int nutritionPoints = 0;

            if (nutritionMeetings >= 1 && nutritionMeetings <= 3)
            {
                nutritionPoints = 10;
            }
            else if (nutritionMeetings == 4)
            {
                nutritionPoints = 40;
            }
            return nutritionPoints;
        }
    }
}
