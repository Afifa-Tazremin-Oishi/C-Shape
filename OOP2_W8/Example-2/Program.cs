using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {

        public static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 30, b = 60;
            Console.WriteLine("Before Swapping a & b is {0} & {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After  Swapping a & b is {0} & {1}", a, b);
        }
    }
}
