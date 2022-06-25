using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    class Program
    {/*
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum WeekDays
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum WeekDays
        {
            Monday ,
            Tuesday,
            Wednesday,
            Thursday = 1,
            Friday,
            Saturday,
            Sunday
        }
      * */
        enum WeekDays
        {
            Monday=9,
            Tuesday=2,
            Wednesday=3,
            Thursday = 1,
            Friday=4,
            Saturday=6,
            Sunday=10
        }
        enum Categories
        {
            Electronics = 1,
            Food = 7,
            Arts = 3,
            Fashion = 2
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday);
            Console.WriteLine(WeekDays.Sunday);

            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine((int)WeekDays.Thursday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Saturday);
            Console.WriteLine((int)WeekDays.Sunday);

            string[] value = Enum.GetNames(typeof(Categories));
            foreach(string s in value )
            {
                Console.WriteLine(s);
            }

            int[] n = (int[])Enum.GetValues(typeof(Categories));
            foreach (int x in n)
            {
                Console.WriteLine(x);
                Console.ReadKey();
            }

        }
    }
}
