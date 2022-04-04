using System;
using System.Reflection;

namespace UpDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal shark = new Shark();
            //Eagle eagle = new Eagle();
            //eagle.ClawLength = 100;

            //Bird anim = eagle;


            //string s = "salam";
            //int a = 15;

            //Object[] objs = { shark, eagle, s, a, anim };


            //foreach (var item in objs)
            //{
            //    if (item is Eagle e)
            //    {
            //        e.Test();
            //    }
            //}

            //Console.WriteLine(shark);


            //int a = 5;
            //long l = 100000000000000000;

            //a = (int)l;

            //Console.WriteLine(a);

            //Animal a1 = new Shark();


            //Shark s1 = a1 as Shark;

            //if (s1!=null)
            //{
            //    Console.WriteLine("Isledi");
            //}
            //else
            //{
            //    Console.WriteLine("Olmadi");
            //}


            //if (a1 is Shark)
            //{
            //    Shark s1 = (Shark)a1;
            //    Console.WriteLine("Oldu");
            //}
            //else
            //{
            //    Console.WriteLine("Olmaz");
            //}

            //USD usd = new USD(500);
            //AZN azn1 = new AZN(340);


            //AZN azn = usd;

            //USD usd1 = azn1;

            //Console.WriteLine(usd1.Amount);


            //Student stu = new Student("Mamed", "Aliyev", 24, 90);
            //Student stu2 = new Student("Isa", "Balayev", 26, 70);

            //Employee emp = stu;
            //Employee emp2 = stu2;

            //Console.WriteLine(emp.Name);
            //Console.WriteLine(emp.Surname);
            //Console.WriteLine(emp.Age);
            //Console.WriteLine(emp.Salary);

            //Console.WriteLine("-------------------");
            //Console.WriteLine(emp2.Name);
            //Console.WriteLine(emp2.Surname);
            //Console.WriteLine(emp2.Age);
            //Console.WriteLine(emp2.Salary);

            //Employee emp = new Employee("Mamed", "Aliyev", 41, 2300);
            //Employee emp2 = new Employee("Isa", "Aliyev", 41, 4000);


            //Console.WriteLine(emp > emp2);

            USD usdV = new USD(300);

            AZN aznV = new AZN(500);

            Console.WriteLine(aznV > usdV);

        }
    }


    public class USD
    {
        public double Amount { get; set; }
        public USD(double Amount)
        {
            this.Amount = Amount;
        }

        public static implicit operator AZN(USD usd)
        {
            return new AZN(usd.Amount*1.7);
        }
        public static implicit operator USD(AZN azn)
        {
            return new USD(azn.Amount / 1.7);
        }

        public static bool operator >(USD u, AZN a)
        {
            return u.Amount > a.Amount;
        }
        public static bool operator <(USD u, AZN a)
        {
            return u.Amount < a.Amount;
        }

    }

    public class AZN
    {
        public double Amount { get; set; }
        public AZN(double Amount)
        {
            this.Amount = Amount;
        }

        public static bool operator >(AZN a, USD u)
        {
            return a.Amount > (u.Amount * 1.7);
        }
        public static bool operator <(AZN a, USD u)
        {
            return a.Amount < (u.Amount * 1.7);
        }

    }

    public abstract class Animal : Object
    {
        public void Eat() { }
    }

    public abstract class Fish : Animal
    {
        public void Swim() { }
    }

    public abstract class Bird : Animal
    {
        public void Fly() { }
    }

    public class Shark : Fish
    {
        public int TeethCount { get; set; }
    }

    public class Eagle : Bird
    {
        public int ClawLength { get; set; }
        public void Test()
        {
            Console.WriteLine("salam");
        }
    }

    public class Swan : Bird
    {
        public int WingSpan { get; set; }

    }

}
