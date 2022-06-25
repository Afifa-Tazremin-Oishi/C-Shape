using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] newArray = new int[3];

            newArray[0]= 5;
            newArray[1]= 10;
            newArray[2]= 15;
            //newArray[3]= 20;

            Array.Resize(ref newArray, 5);
            newArray[3] = 20;
            newArray[4] = 25;

            Array.Resize(ref newArray, 6);
            newArray[5] = 30;
            //newArray[6] = 35;

            ArrayList myArray = new ArrayList();
            myArray.Add(1);
            Console.WriteLine(myArray.Capacity);
            myArray.Add(2);
            myArray.Add('A');
            Console.WriteLine(myArray.Capacity);
            myArray.Add(3);
            myArray.Add(4);
            Console.WriteLine(myArray.Capacity);
            myArray.Add(5);
            myArray.Add("A");
            myArray.Add("B");
            myArray.Add(6);
            myArray.Add(7);
            myArray.Add(8);
            Console.WriteLine(myArray.Capacity);

            myArray.Insert(0, "C");
            myArray.Insert(0, "B");
            myArray.Insert(0, "A");

            foreach (object item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //myArray.Remove(5);
            myArray.Remove("B");
            //myArray.RemoveAt(5);

            foreach (object item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
