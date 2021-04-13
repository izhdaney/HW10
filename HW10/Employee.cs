using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Employee : Person
    {
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override int Age { get; set; }

        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DisplayFullName();
        }
        public override void DisplayFullName()
        {
            Console.WriteLine($"FirstName - {FirstName}\nLastName - {LastName}\nAge - {Age}");
        }

    }
}
