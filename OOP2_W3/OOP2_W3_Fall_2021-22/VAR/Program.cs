using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    class Program
    {
        static void Main(string[] args)
        {
            ///int value
            var number = 30;
            Console.WriteLine("Var can hold int values    : " + number);
            ///string value
            var name = "Cecilia Hansen";
            Console.WriteLine("Var can hold string values : " + name);
            ///array
            var even = new[] { 2, 4, 6, 8, 10 };
            Console.WriteLine("Var can hold array numbers : ");
            foreach(var num in even)
            {
                Console.WriteLine("{0}",num);
            }
            //for loop
            for(var x=1;x<=10;x++)
            {
                Console.WriteLine("PROUD AIUBIAN");
            }
            var p = 10;//VALID
            // var y; y = 10; // Invalid Line
            // var z = null;  // Invalid Line

            // Get the Types 
            Console.WriteLine("\n\n");
            var i = 100;
            Console.WriteLine("i value: {0}, type: {1}", i, i.GetType());
            var j = "Welcome to Tutlane";
            Console.WriteLine("j value: {0}, type: {1}", j, j.GetType());
            var k = true;
            Console.WriteLine("k value: {0}, type: {1}", k, k.GetType());
            var l = 20.50;
            Console.WriteLine("l value: {0}, type: {1}", l, l.GetType());
            Console.ReadLine();
        }
    }
}
