using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Student
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public Student(string myFirstName, string myLastName, string myEmail)
        {
            FirstName = myFirstName;
            LastName = myLastName;
            EmailAddress = myEmail;
        }

        public override string ToString()
        {
            return String.Format($"{FirstName} {LastName} | {EmailAddress}");
        }
    }
}
