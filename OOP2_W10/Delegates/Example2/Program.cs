using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        public delegate void DelMethod(int x, int y);

        class Test
        {
            public void Add(int x, int y)
            {
                Console.Write("Add : ");
                Console.WriteLine(x+y);
            }
            public void Sub(int x, int y)
            {
                Console.Write("Sub : ");
                Console.WriteLine(x - y);
            }
        }

        static void Main(string[] args)
        {
            Test obj = new Test();
            DelMethod d = new DelMethod(obj.Add);
            d += new DelMethod(obj.Sub);
            d(10, 5);// Add Sub
            d -= new DelMethod(obj.Add);
            d(20, 10);//Sub
            Console.WriteLine("===========================================");
            d += new DelMethod(obj.Add);
            d(20,15);//Sub Add
        }
    }
}
