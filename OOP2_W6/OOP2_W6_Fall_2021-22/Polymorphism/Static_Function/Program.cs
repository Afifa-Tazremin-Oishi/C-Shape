using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Function
{
    class Program
    {

        public void Print() { Console.WriteLine("Empty"); }
        public void Print(int a) { Console.WriteLine("int"); }
        public void Print(int a, int b) { Console.WriteLine("int,int"); }
        public void Print(int a, int b, int c) { Console.WriteLine("int,int,int,"); }
        public void Print(string a) { Console.WriteLine("string"); }
        public void Print(string a, string b) { Console.WriteLine("string,string"); }
        public void Print(string a, string b, string c) { Console.WriteLine("string,string,string"); }
        public void Print(int a, string b) { Console.WriteLine("int,string"); }
        public void Print(string a, int b) { Console.WriteLine("string,int"); }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();
            p.Print(5);
            p.Print(5, 5);
            p.Print(5, 5, 5);
            p.Print("5");
            p.Print("5", "5");
            p.Print("5", "5", "5");
            p.Print(5, "5");
            p.Print("5", 5);
        }
    }
}
