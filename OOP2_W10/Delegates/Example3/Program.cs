using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        public delegate T Addition<T>(T para1, T para2);

        static void Main(string[] args)
        {
            Addition<int> s = Sum;
            Console.WriteLine(s(30,20));

            Addition<string> con = Concat;
            Console.WriteLine(con("Hello", " World!"));
        }

        public static int Sum(int value1,int value2)
        {
            return value1 + value2;
        }
        public static string Concat(string value1, string value2)
        {
            return value1 + value2;
        }

    }
}
