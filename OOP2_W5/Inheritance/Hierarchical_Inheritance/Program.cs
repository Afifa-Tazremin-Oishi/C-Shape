using System;

using System.Collections.Generic;
using System.Collections;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Q_1

{
    interface Test
    {
        int sum(int a, int b);
    }
class Cal : Test
    {
        public int sum(int a, int b)
        {
            return a % b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t;
            t = new Cal();
            Console.WriteLine(t.sum(6, 5));
            Console.ReadKey();
        }
    }
}

