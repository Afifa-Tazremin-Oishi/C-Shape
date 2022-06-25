using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class ScientificCalculator : BasicCalculatorInterface,ScientificCalculatorInterface
    {
        public int division(int x, int y)
        {
            Console.Write("The division of {0} and {1} is  ", x, y);
            return x / y;
        }

        public int multiplication(int x, int y)
        {
            Console.Write("The multiplication of {0} and {1} is  ", x, y);
            return x * y;
        }

        public int sub(int x, int y)
        {
            Console.Write("The sub of {0} and {1} is  ", x, y);
            return x - y;
        }

        public int sum(int x, int y)
        {
            Console.Write("The sum of {0} and {1} is  ", x, y);
            return x + y;
        }

        public double root(int x)
        {
            Console.Write("The root of {0} is    ", x);
            return Math.Sqrt(x);
            
        }
        public double power(int x,int y)
        {
            Console.Write("The power {0} of {1} is    ", x,y);
            return Math.Pow(x,y);
            
        }

      

        public int square(int x)
        {
            Console.Write("The square of {0}  is  ", x);
            return x * x;
        }

        public int XtoY(int x, int y)
        {
            Console.Write("The X^Y of {0}  is   ", x);
            return y;
        }
    }
}
