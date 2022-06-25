using System;
using System.Collections;



namespace Generics_Collection
{
    interface IFlyable
    {
        void fly();
    }
    interface IEatable
    {
        void eat();
    }
    class Bird : IFlyable, IEatable
    {
        public void fly()
        {
            Console.Write(" Bird flying");
        }
        public void eat()
        {
            Console.Write("Bird eats");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Bird b = new Bird();
            b.eat();
            b.fly();
            Console.ReadKey();

        }
    }
}