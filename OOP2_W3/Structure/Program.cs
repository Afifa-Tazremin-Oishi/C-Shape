using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        struct Book
        {
            public string title;
            public string author;
            public int no_page;
        };
        public struct person
        {
            public string name;
            public int age;
            public int weight;
        };
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2;

            b1.title = "C# Programming";
            b1.author = "Cecilia";
            b1.no_page = 500;

            b2.title = "JAVA Programming";
            b2.author = "Hansen";
            b2.no_page = 600;

            Console.WriteLine("Book1 Details>>>>>>>>>>>>>>>");
            Console.WriteLine("Book Name   : "+ b1.title);
            Console.WriteLine("Author Name : "+ b1.author);
            Console.WriteLine("No of Pages : "+b1.no_page);

            Console.WriteLine("\nBook2 Details>>>>>>>>>>>>>>>");
            Console.WriteLine("Book Name   : " + b2.title);
            Console.WriteLine("Author Name : " + b2.author);
            Console.WriteLine("No of Pages : " + b2.no_page);

            // Declare P1 of type Person
            person P1;
            P1.name = "Cecilia Hansen";
            P1.age = 21;
            P1.weight = 60;
            Console.WriteLine("\nPerson Information>>>>>>>>>>");
            Console.WriteLine("\nName : {0}   Age : {1}  Weight : {2}\n", P1.name,P1.age,P1.weight);
            Console.ReadKey();
        }
    }
}
