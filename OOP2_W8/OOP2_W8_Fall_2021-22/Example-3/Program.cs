using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        public static void PassByValue(int value)
        {
            value = value + 30;
            Console.WriteLine(value);
        }
        public static void PassByRef(ref int value)
        {
            value = 100;
            value = value + 30;
            Console.WriteLine(value);
        }
        public static void PassByOut(out int value)
        {
            value = 100;
            value = value + 30;
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            //int value = 10;
            //PassByValue(value);

            int value = 10;
            PassByRef(ref value);

            //int value;
            //PassByOut(out value);

        }
    }
}
