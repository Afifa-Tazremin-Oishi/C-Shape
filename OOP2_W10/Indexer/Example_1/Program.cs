using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Student
    {
        //public int[] array = new int[4];
        // public int[] array = { 1, 2, 3, 4, 5 };

        private int[] array = { 1, 2, 3, 4, 5 }; 
        public int this[int index] 
        {
            get
            {

                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    Console.WriteLine("Wrong Index");
                }
                return 0;
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    if (value > 0)
                    {
                        array[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Data");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Index");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //// s.array[5] = 10;  //will create exception
            //foreach (var item in s.array)
            //{
            //    Console.WriteLine(item);
            //}

            Student std = new Student();
           // std.this // invalid for searching indexer
            std[0] = 10;
            std[0] = -10;
            std[6] = 100;
            std[7] = -100;
            Console.ReadKey();
        }
       
    }
    
}

