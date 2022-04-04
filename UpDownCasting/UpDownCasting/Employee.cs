using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UpDownCasting
{
    class Employee : Person
    {
        public int Salary { get; set; }

        public Employee(string Name, string Surname, int Age, int Salary) : base(Name, Surname, Age)
        {
            this.Salary = Salary;
        }

        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Name == e2.Name;

            //foreach (PropertyInfo property in e1.GetType().GetProperties())
            //{
            //   Console.WriteLine($"{property.GetValue(e1)} - {property.GetValue(e2)}");
            //    if (property.GetValue(e1) != property.GetValue(e2))
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Name != e2.Name;
        }

        public static bool operator ==(Employee e1, Student s1)
        {
            return e1.Name == s1.Name;
        }
        public static bool operator !=(Employee e1, Student s1)
        {
            return e1.Name != s1.Name;
        }

        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }

        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.Salary < e2.Salary;
        }

    }
}
