using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_Inheritance
{
    class A
    {
        public int a;
        public A()
        {
            a = 9;
            Console.WriteLine("Constructor from class A.....");
        }

    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 5;
            Console.WriteLine("Constructor from class B.....");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Level Inheritance");
            B obj = new B();
            Console.WriteLine("a = {0}", obj.a);
            Console.WriteLine("b = {0}", obj.b);

            A obj2 = new A();
            Console.WriteLine("a = {0}", obj2.a);
            ////Console.WriteLine("b = {0}", obj2.b); Invalid
        }
    }
}
