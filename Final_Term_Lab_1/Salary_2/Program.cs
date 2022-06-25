using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write(" Enter the number of Admin officers: ");
            int empNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < empNum; i++)
            {
                Console.Write("Enter the monthly salary of Admin officers: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                int yearlySal = salary * 12;
                Console.WriteLine("Admin yearly salary is: " + yearlySal);

            }
            Console.Write("Enter the number of Manager: ");
            int manNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < manNum; i++)
            {
                Console.Write("Enter the monthly salary of Manager: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                int yearlySal = salary * 12;
                Console.WriteLine("Manager yearly salary is: " + yearlySal);

            }
            Console.Write("Enter the number of SalesMan: ");
            int salmanNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < salmanNum; i++)
            {
                Console.Write("Enter the monthly salary of SalesMan: ");
                int salary = Convert.ToInt32(Console.ReadLine());

                int yearlySal = salary * 12;
                Console.WriteLine("SalesMan yearly salary is: " + yearlySal);

            }

            Console.ReadKey();

        }
    }
}
