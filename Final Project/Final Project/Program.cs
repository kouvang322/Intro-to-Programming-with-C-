using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        private const int AddStudent = 1;
        private const int DeleteStudent = 2;
        private const int EditStudent = 3;
        private const int ListStudents = 4;
        private const int Exit = 5;

        static int GetMenuChoice()
        {
            Console.WriteLine("Student Club Management");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. List Student");
            Console.WriteLine("5. Exit");

            Console.Write("\nSelect an option: ");

            int userInput = GetValidIntChoice();

            return userInput;
        }

        static void Main(string[] args)
        {
            StudentClub studentClubList = new StudentClub();

            int menuOption = GetMenuChoice();

            while (menuOption != Exit)
            {
                switch (menuOption)
                {
                    case AddStudent:
                        studentClubList.AddStudent();
                        break;
                    
                    case DeleteStudent:
                        studentClubList.DeleteStudent();
                        break;

                    case EditStudent:
                        studentClubList.EditStudent();
                        break;

                    case ListStudents:
                        studentClubList.ListStudents();
                        break;
                }
                 
                menuOption = GetMenuChoice();
            }
            Console.Read();
        }

        //making sure user inputs a valid option
        public static int GetValidIntChoice()
        {
            string userInput = (Console.ReadLine());

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number only please.");
                Console.Write("\nSelect an option: ");
                userInput = Console.ReadLine();
            }

            int userNumInput = Convert.ToInt32(userInput);

            return userNumInput;
        }
    }
}
