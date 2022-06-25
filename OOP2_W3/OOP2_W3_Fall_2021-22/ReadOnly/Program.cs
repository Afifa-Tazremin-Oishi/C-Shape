using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
        public int x;
        //readonly
        public readonly int y = 30;
        public readonly int z;

        public Program()
        {
            z = 50;
        }
        public Program(int r1,int r2, int r3)
        {
            x = r1;
            y = r2;
            z = r3;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program(11,22,33);
            Console.WriteLine("x = "+p1.x+" y = "+p1.y+" z = "+p1.z);
            Program p2 = new Program();
            p2.x = 80;
            //p2.y = 100; Invalid 
            Console.WriteLine("x = " + p2.x + " y = " + p2.y + " z = " + p2.z);

        }
    }
}
