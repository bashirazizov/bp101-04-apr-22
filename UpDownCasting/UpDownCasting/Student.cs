using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCasting
{
    class Student : Person
    {
        public int AverageScore { get; set; }

        public Student(string Name, string Surname, int Age, int AverageScore) : base(Name, Surname, Age)
        {
            this.AverageScore = AverageScore;
        }

        public static implicit operator Employee(Student student)
        {
            int salary = student.AverageScore > 80 ? 2000 : 1000;

            return new Employee(student.Name, student.Surname, student.Age, salary);
        }

        public static implicit operator Student(Employee employee)
        {
            int averageScore = employee.Salary > 2000 ? 90 : 70;

            return new Student(employee.Name, employee.Surname, employee.Age, averageScore);
        }
    }
}
