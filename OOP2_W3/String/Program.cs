using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // String using Constructor
            char[] chars = { 'C', 'e', 'c', 'i', 'l', 'i', 'a' };
            string name = new string(chars);
            Console.WriteLine(name);
            //String using Literal
            string fname = "Cecilia";
            string lname = "Hansen";
            string age = "25";
            Console.WriteLine("First Name : "+fname);
            Console.WriteLine("Last  Name : "+lname);
            Console.WriteLine("Age        : "+age);
            /*
            Console.WriteLine("First Name : {0}", fname);
            Console.WriteLine("Last  Name : {0}", lname);
            Console.WriteLine("Age        : {0}", age);
            */

            //Date Time 
            //string nowDateTime = "Date  : " + DateTime.Now.ToString("D");
            //string nowDateTime = "Date  : " + DateTime.Now.ToString("MM-dd-yy");
            //string nowDateTime = "Date  : " + DateTime.Now.ToString("hh:mm:ss");
            string nowDateTime = "Date    : " + DateTime.Now.ToString();


            Console.WriteLine(nowDateTime);
        }
    }
}
