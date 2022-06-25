using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            double radius;
            Console.Write("Enter radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
            double Circle_area = pi * radius * radius;
            // pi = 4; Invalid 
            Console.WriteLine("Radius is {0}  &  Area is {1} : ", radius, Circle_area);

        }
    }
}
