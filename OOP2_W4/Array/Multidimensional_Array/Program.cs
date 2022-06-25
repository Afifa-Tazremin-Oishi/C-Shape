using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
            {
                {11,22,33,44},
                {10,20,30,40},
                {15,25,35,45}
            };
            ////Console.WriteLine(arr[0,2]);
            ////Console.WriteLine(arr[0,5]); Invallid
            //Console.WriteLine(arr.GetLength(0)); // Return Row
            //Console.WriteLine(arr.GetLength(1)); // Return Column
            //// Console.WriteLine(arr.GetLength(2)); Invallid

            //Console.WriteLine(arr.Rank);// Property-> Returns diamension of the array 

            //for (int i = 0; i < 3; i++)//Outer for loop for rows
            //{
            //    for (int j = 0; j < 4; j++)//inner for loop for columns
            //    {
            //        Console.WriteLine(arr[i, j] + " ");
            //    }

            //}

            for (int i = 0; i < arr.GetLength(0); i++)//Outer for loop for rows
            {
                for (int j = 0; j < arr.GetLength(1); j++)//inner for loop for columns
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
                
            }
        }
    }
}
