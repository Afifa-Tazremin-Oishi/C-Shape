using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level__inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a = 9;
            Console.WriteLine("From A Class");
        }

    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 5;
            Console.WriteLine("From B Class");
        }

    }
    class C : B
    {
        public int c;
        public C()
        {
            c = 8;
            Console.WriteLine("From C Class");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multilevel Inheritance");
            A obj1 = new A();
            Console.WriteLine("a = {0}", obj1.a);
            ////Console.WriteLine("b = {0}", obj1.b);
            ////Console.WriteLine("c = {0}", obj1.c);

            B obj2 = new B();
            Console.WriteLine("a = {0}", obj2.a);
            Console.WriteLine("b = {0}", obj2.b);
            ////Console.WriteLine("c = {0}", obj2.c);

            C obj3 = new C();
            Console.WriteLine("a = {0}", obj3.a);
            Console.WriteLine("b = {0}", obj3.b);
            Console.WriteLine("c = {0}", obj3.c);
        }
    }
}
