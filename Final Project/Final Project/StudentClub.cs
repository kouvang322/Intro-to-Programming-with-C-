using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class StudentClub
    {
        private List<Student> studentList = new List<Student>();

        public void AddStudent()
        {
            Console.Write("Enter first name: ");
            string studentFirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string studentLastName = Console.ReadLine();

            Console.Write("Enter email: ");
            string studentEmail = GetValidEmail();

            Student studentAdd = new Student(studentFirstName, studentLastName, studentEmail);

            studentList.Add(studentAdd);

            Console.WriteLine("Student added successfully\n");
        }

        public void ListStudents()
        {
            while (studentList.Count == 0)
            {
               
                Console.WriteLine("There are no current students in list.\n");
                Console.WriteLine("Start by adding a student");
               
                //Making the user add something to the list before they do the desired option.
                AddStudent();
            }

            for (int i = 0; i < studentList.Count; i++)
            {
                Student aStudent = studentList[i];
                Console.WriteLine($"{i + 1}. {aStudent.ToString()}\n");
            }
        }

        public void DeleteStudent()
        {
            ListStudents();

            Console.Write("Enter # to delete: ");
            int studentNum = GetValidListChoiceDelete();

            while (studentNum > studentList.Count)
            {
                Console.WriteLine("Please select from the list.");
                Console.Write("Enter # to delete: ");
                studentNum = GetValidListChoiceDelete();
            }

            studentList.RemoveAt(studentNum - 1);

            Console.WriteLine("Student deleted successfully\n");

        }

        public void EditStudent()
        {
            ListStudents();

            Console.Write("Enter # to edit: ");
            int studentNum = GetValidListChoiceEdit();

            while (studentNum > studentList.Count)
            {
                Console.WriteLine("Please select from the list.");
                Console.Write("Enter # to edit: ");
                studentNum = GetValidListChoiceEdit();
            }

            // Having the user change the values inside the correct listed item.
            Console.Write("Enter new first name: ");
            studentList[studentNum - 1].FirstName = Console.ReadLine();

            Console.Write("Enter new last name: ");
            studentList[studentNum - 1].LastName = Console.ReadLine();

            Console.Write("Enter new email: ");
            studentList[studentNum - 1].EmailAddress = GetValidEmail();

            Console.WriteLine("Student edited successfully\n");

        }

        //making sure the user is picking which student to delete from to the list 
        public static int GetValidListChoiceDelete()
        {
            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number that corresponds to the list.");
                Console.Write("\nEnter # to delete: ");
                userInput = Console.ReadLine();
            }

            int userNumInput = Convert.ToInt32(userInput);

            return userNumInput;
        }

        //making sure the user is picking which student to edit from to the list 
        public static int GetValidListChoiceEdit()
        {
            string userInput = Console.ReadLine();

            while (!(int.TryParse(userInput, out int i)))
            {
                Console.WriteLine("Enter a number that corresponds to the list.");
                Console.Write("\nEnter # to edit: ");
                userInput = Console.ReadLine();
            }

            int userNumInput = Convert.ToInt32(userInput);

            return userNumInput;
        }

        //Validate correct email format
        public static string GetValidEmail()
        {
            string userInput = Console.ReadLine();

            while (!(userInput.Contains("@")))
            {
                Console.WriteLine("Please enter a valid email address.");
                Console.Write("Enter email: ");
                userInput = Console.ReadLine();
            }
                return userInput;
        }
    }
}
