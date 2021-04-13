using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class Dean : Employee, ISalary, IEmploymentYear
    {
        public string FacultyName { get; set; }

        public void Salary()
        {
            Console.WriteLine("Dean salary - 700$");
        }

        public Dean(string firstName, string lastName, int age, string facultyName) : base(firstName, lastName, age)
        {
            FacultyName = facultyName;
            Console.WriteLine($"Faculty name - {FacultyName}");
        }
    }
}
