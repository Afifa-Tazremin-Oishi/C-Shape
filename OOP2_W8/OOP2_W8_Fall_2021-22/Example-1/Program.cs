using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{

    class Template
    {
        //public static void Array(int [] arr)
        //{
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        Console.Write(arr[i]+" ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void Array(string [] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.WriteLine();
        //}

        public static void Array<T>(T [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static bool Check<T>( T a, T b)
        {
            Console.WriteLine(typeof(T));
            bool c = a.Equals(b);
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 5;
            number[1] = 10;
            number[2] = 15;
           // number[3] = 20;

            Template.Array(number);

            string [] name = { "Ahmed","Khan","Beyazid" };
            Template.Array(name);

            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine(Template.Check(10, 10));
            Console.WriteLine(Template.Check(10, 20));
            Console.WriteLine(Template.Check("A", "A"));
            Console.WriteLine(Template.Check("A", "B"));
            Console.WriteLine(Template.Check('A', 'A'));
            Console.WriteLine(Template.Check('A', 'B'));
            Console.WriteLine(Template.Check(10.00, 10));
            Console.WriteLine(Template.Check(10, 10.00));
            Console.WriteLine(Template.Check(10, 10.50));
            //Console.WriteLine(Template.Check(10, "A"));
        }
    }
}
