using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{

    class Employee
    {
        public double salary;
        public void Display()
        {
            Console.WriteLine("Salary of the Employee : " + salary);
            Console.WriteLine("Yealry salary of the Employee : " + salary * 12);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee();
                Console.WriteLine("Employee Name : Managers ");
                e1.salary = 30000;
                e1.Display();
                Console.WriteLine();
                Employee e2 = new Employee();

                Console.WriteLine("Employee Name : Admin Officers ");
                e2.salary = 25000;
                e2.Display();
                Console.WriteLine();
                Employee e3 = new Employee();
                Console.WriteLine("Employee Name : Salesman ");
                e3.salary = 20000;
                e3.Display();
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
