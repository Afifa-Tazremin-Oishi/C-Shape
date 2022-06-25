using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();
            Console.WriteLine("Basic Calculator Functionality\n\n");
            Console.WriteLine(basicCalculator.sum(10, 5)); 
            Console.WriteLine(basicCalculator.sub(10, 5));
            Console.WriteLine(basicCalculator.multiplication(10, 5));
            Console.WriteLine(basicCalculator.division(10, 5));
            Console.WriteLine("\n");

            ScientificCalculator scientificCalculator = new ScientificCalculator();
            Console.WriteLine("Scientific Calculator Functionality\n\n");
            Console.WriteLine(scientificCalculator.sum(20, 10));
            Console.WriteLine(scientificCalculator.sub(15, 5));
            Console.WriteLine(scientificCalculator.multiplication(15, 5));
            Console.WriteLine(scientificCalculator.division(30, 10));
            Console.WriteLine(scientificCalculator.root(129));
            Console.WriteLine(scientificCalculator.square(11));
            Console.WriteLine(scientificCalculator.power(5, 2));
           // Console.WriteLine(scientificCalculator.Sin(90));
            Console.WriteLine(scientificCalculator.XtoY(5,2));
            Console.ReadLine();


        }
    }
}
