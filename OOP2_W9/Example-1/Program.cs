using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> mynumber = new List<int>();
            Console.WriteLine(mynumber.Capacity);
            mynumber.Add(10);
            Console.WriteLine(mynumber.Capacity);
            mynumber.Add(20);
            mynumber.Add(30);
            mynumber.Add(40);
            Console.WriteLine(mynumber.Capacity);
            mynumber.Add(50);
            Console.WriteLine(mynumber.Capacity);
            mynumber.Add(60);
            mynumber.Add(70);
            mynumber.Add(80);
            mynumber.Add(90);
            Console.WriteLine(mynumber.Capacity);
            mynumber.Add(100);

            foreach(int item in mynumber)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            Student s1 = new Student { NAME = "A", ID = 101 };
            Student s2 = new Student { NAME = "B", ID = 102 };
            Student s3 = new Student { NAME = "C", ID = 103 };
            Student s4 = new Student { NAME = "D", ID = 104 };
            Student s5 = new Student { NAME = "E", ID = 105 };

            List<Student> stuList = new List<Student>();

            stuList.Add(s1);
            stuList.Add(s2);
            stuList.Add(s3);
            stuList.Add(s4);
            stuList.Add(s5);


            foreach (Student item in stuList)
            {
                Console.WriteLine(" Student name is : {0} and id is : {1}",item.NAME,item.ID);
            }
            Console.WriteLine();
            
        }
    }
}
