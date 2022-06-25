using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    
    public sealed class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed class which can;t be further inherited");
        }
    }
    public class Derived : BaseClass
    {
        // this Derived class can;t inherit BaseClass because it is sealed  
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
            obj.Display();
            Console.ReadLine();
        } 
    }

     


    ////////////////// Another Exmaple ///////////////////////
    /*
    sealed class Users
    {

        public string name = "Cicilia Hansen";

        public string location = "Denmark";

        public void GetInfo()
        {

            Console.WriteLine("Name: {0}", name);

            Console.WriteLine("Location: {0}", location);

        }

    }

    // Derived Class

    public class Details : Users
    {

        public int age = 32;

        public void GetAge()
        {

            Console.WriteLine("Age: {0}", age);

        }

    }

    class Program
    {

        static void Main(string[] args)
        {

            Details d = new Details();

            d.GetAge();

            d.GetInfo();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }
    */
    ////////////////// Another Exmaple ///////////////////////
    /*
    class Program
    {
    public class BaseClass  
        {  
            public virtual void Display()  
            {  
                Console.WriteLine("Virtual method");  
            }  
        }  
        public class DerivedClass : BaseClass  
        {  
            // Now the display method have been sealed and can;t be overridden  
            public override sealed void Display()  
            {  
                Console.WriteLine("Sealed method");  
            }  
        }  
        //public class ThirdClass : DerivedClass  
        //{  
        //    public override void Display()  
        //    {  
        //        Console.WriteLine("Here we try again to override display method which is not possible and will give error");  
        //    }  
        //}  
        static void Main(string[] args)  
        {  
            DerivedClass ob1 = new DerivedClass();  
            ob1.Display();  
            Console.ReadLine();  
        }
    }  

    */
    ////////////////// Another Exmaple ///////////////////////
    /*
    public class A
    {

        public virtual void GetInfo()
        {

            Console.WriteLine("Base Class A Method");

        }

        public virtual void Test()
        {

            Console.WriteLine("Base Class A Test Method");

        }

    }

    public class B : A
    {

        public sealed override void GetInfo()
        {

            Console.WriteLine("Derived Class B Method");

        }

        public override void Test()
        {

            Console.WriteLine("Derived Class B Test Method");

        }

    }

    public class C : B
    {

        // Compile time error

        public override void GetInfo()
        {

            Console.WriteLine("Age: {0}", base.age);

        }

        public override void Test()
        {

            Console.WriteLine("Derived Class C Test Method");

        }

    }

    class Program
    {

        static void Main(string[] args)
        {

            C c = new C();

            c.GetInfo();

            c.Test();

            Console.WriteLine("\nPress Enter Key to Exit..");

            Console.ReadLine();

        }

    }*/
    
}
