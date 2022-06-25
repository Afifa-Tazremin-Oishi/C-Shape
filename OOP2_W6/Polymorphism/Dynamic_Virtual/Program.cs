using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Virtual
{
    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Square : Drawing
    {
        public double Length { get; set; }
        public Square()
        {
            Length = 6;
        }
        public  override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
            Height = 5.3;
            Width = 3.4;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            //Circle circle = new Circle();
            //Console.WriteLine("Area :" + circle.Area());

            //Square square = new Square();
            //Console.WriteLine("Area :" + square.Area());

            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine("Area :" + rectangle.Area());



            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());
        }
    }  
}
