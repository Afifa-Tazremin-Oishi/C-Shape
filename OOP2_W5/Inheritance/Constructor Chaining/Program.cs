using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{

    class User
    {
        // public User():this("","")
        public User()
        {
            Console.Write("Hi! ");
        }
        public User(string a): this()
        {
            Console.Write(a);
        }
        public User(string a, string b) : this("welcome")
        {
            Console.Write(a + " " + b);
        }
    }

    class Student : User
    {
        public Student() : base("", "to ")
        {
            Console.Write("CS Department. ");
        }
        public Student(string a): this("", "Proud ")
        {
            Console.Write(a);
        }
        public Student(string a, string b)
        {
            Console.Write(a + " " + b);
        }
        public Student(string a, string b,string c)
        {
            Console.Write(a + " " + b+" "+c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User(" to", "AIUB");
            Console.WriteLine();
            Student s = new Student();
            Console.WriteLine();
            Student s2 = new Student("AIUBIAN");
            Console.WriteLine();
        }
    }

}
