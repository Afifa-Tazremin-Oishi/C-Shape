using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{

    abstract class Shape
    {
        public abstract double area();
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double area()
        {
            return (3.14 * radius * radius);
        }
    }
    class Square : Shape
    {
        private double side;
        public Square(double s)
        {
            side = s;
        }
        public override double area()
        {
            return (side * side);
        }
    }
    class Triangle : Shape
    {
        private double tbase;
        private double theight;
        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }
        public override double area()
        {
            return (0.5 * tbase * theight);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5.0);
            Console.WriteLine("Area of Circle    = {0}", c.area());
            Square s = new Square(2.5);
            Console.WriteLine("Area of Square    = {0}", s.area());
            Triangle t = new Triangle(2.0, 5.0);
            Console.WriteLine("Area of Triangle  = {0}", t.area());
        }
    }


    ///////////////////////////// Another Example ///////////////////////

/*
    abstract class Employee //abstract class
    {
        public abstract int GetSalary(); //abstract method
    }

    class Developer : Employee
    {
        private int salary;
        public Developer(int s)
        {
            salary = s;
        }
        public override int GetSalary()
        {
            return salary;
        }
    }

    class Driver : Employee
    {
        private int salary;
        public Driver(int s)
        {
            salary = s;
        }
        public override int GetSalary()
        {
            return salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer(5000);
            Driver d2 = new Driver(3000);

            int a, b;

            a = d1.GetSalary();
            b = d2.GetSalary();
            Console.WriteLine("Salary of developer : {0}", a);
            Console.WriteLine("Salary of driver : {0}", b);
        }
    }*/
}
