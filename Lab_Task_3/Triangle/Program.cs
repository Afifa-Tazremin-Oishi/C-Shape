using System;



namespace Triangle
{
    public class Triangle
    {
        private int x;
        private int y;
        private int z;



        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Value!");
                }
                else if (value >= 60)
                {
                    Console.WriteLine("Value can't be upto 60");
                }
                else
                {
                    x = value;
                }

            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Value!");
                }
                else if (value >= 60)
                {
                    Console.WriteLine("Value can't be upto 60");
                }
                else
                {
                    y = value;
                }
            }
        }
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Value!");
                }
                else if (value >= 60)
                {
                    Console.WriteLine("Value can't be upto 60");
                }
                else
                {
                    z = value;
                }
            }
        }



        public void TestTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("The triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Console.Write("Enter the x: ");
            t.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the y: ");
            t.Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the z: ");
            t.Z = Convert.ToInt32(Console.ReadLine());



            t.TestTriangle();



        }
    }
}