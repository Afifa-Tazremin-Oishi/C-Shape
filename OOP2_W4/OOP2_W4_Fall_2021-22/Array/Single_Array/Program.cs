using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // string a = "Ahmed","Khan"; Invalid

            //int[] arr = new int[4];
            ////ctrl+c ctrl+v
            //arr[0]=11;
            //arr[1]=22;
            //arr[2]=33;
            //arr[3]=44;

            //string[] arr = new string[4];
            ////ctrl+c ctrl+v
            //arr[0] = "Hassan";
            //arr[1] = "Khan";
            //arr[2] = "Ahmed";
            //arr[3] = "Ali";

            //string[] arr = new string[4] { "Hassan", "Khan", "Ahmed", "Ali" };
            string[] arr = { "Hassan", "Hossain", "Ahmed", "Ali" };

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[3]);

            //for(int i=0;i<4;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //for (int i = 0; i < arr.Count(); i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Loop for array foreack
            foreach(string item in arr)
            {
                Console.WriteLine(item);
            }


        }
    }
}
