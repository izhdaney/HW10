using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Lecturer : Employee, ISalary, IEmploymentYear
    {
        public string LectionType { get; set; }

        public void Salary()
        {
            Console.WriteLine("Lecturer salary - 600$");
        }

        public void Employment()
        {
            Console.WriteLine($"Employment Year - 2005");
        }

        public Lecturer(string firstName, string lastName, int age, string lectionType) : base(firstName, lastName, age)
        {
            LectionType = lectionType;
            Console.WriteLine($"Lection Type - {LectionType}");
        }





    }
}
