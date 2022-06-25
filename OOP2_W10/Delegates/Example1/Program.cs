using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        public delegate void DelMethod();
        class Test
        {
            public void Display()
            {
                Console.WriteLine("Display");
            }
            public static void Show()
            {
                Console.WriteLine("Show");
            }
            public static void Print()
            {
                Console.WriteLine("Print");
            }
        }

        static void Main(string[] args)
        {
            Test t = new Test();
            DelMethod del1 = new DelMethod(t.Display);
            del1();
            DelMethod del2 = Test.Show;
            del2();
            DelMethod del3 = new DelMethod(Test.Print);
            del3();
        }
    }
}
