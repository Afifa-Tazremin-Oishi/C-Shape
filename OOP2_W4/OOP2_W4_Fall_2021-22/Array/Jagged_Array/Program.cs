using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
    
                arr[0]= new [] {11,22,33,44,55,66,77,88};
                arr[1]= new [] {10,20,30,40,50,60,70};
                arr[2] = new[] { 1, 2, 3, 4, 5, 6 };

                //Console.WriteLine( arr[0][4]);
                //Console.WriteLine( arr[0][6]);
                //Console.WriteLine( arr[6][6]);

                //for (int i = 0; i < arr.GetLength(0); i++)
                //{
                //    for (int j = 0; j < arr[i].Length; j++)
                //    {
                //        Console.Write(arr[i][j]+" ");
                //    }
                //    Console.WriteLine();
                //}

                foreach (int [] item in arr)
                {
                    foreach (int i in item)
                    {
                        Console.Write(i+" ");
                    }
                    Console.WriteLine();
                }
    
        }
    }
}
