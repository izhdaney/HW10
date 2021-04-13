using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Rector : Employee, ISalary, IEmploymentYear
    {

        public string UniversityName;

        public void Salary()
        {
            Console.WriteLine("Dean salary - 900$");
        }

        public void Employment()
        {
            Console.WriteLine($"Employment Year - 2007");
        }


        public Rector(string firstName, string lastName, int age, string universityName) : base(firstName, lastName, age)
        {
            UniversityName = universityName;
            Console.WriteLine($"University name - {UniversityName}");
        }


    }
}
