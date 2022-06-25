using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    
    class A
    {
        public int a;
        public A(int _a)
        {
            a = _a;
            Console.WriteLine("Constructor A(int): a = {0}", a);
        }
    }
    class B : A
    {
        public int b;
        public B(int _b) : base(0)
        {
            b = _b;
            Console.WriteLine("Constructor B(int): b = {0}", b);
        }
    }
    class C : B
    {
        public int c;

        public C(int _c): base(0)
        {
            c = _c;
            Console.WriteLine("Constructor C(int): c = {0}", c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B objB = new B(4);
            Console.WriteLine("------");
            C objC = new C(5);
        }
    }

    ////////////////// Another Exmaple ///////////////////////
/*

    public class Person
    {
        protected string id = "444-55-6666";
        protected string name = "John L. Malgraine";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("ID: {0}", id);
        }
    }
    class Employee : Person
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", base.id);
            Console.WriteLine("Employee ID: {0}", id);
            Console.WriteLine("Employee ID: {0}", this.id);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee E = new Employee();
            E.GetInfo();
        }
    }*/
}