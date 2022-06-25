using System;


namespace Comission_Basic
{


    class Program
    {


        class total
        {


            public int week;
            public double comm;
            public total(int week, double comm)
            {
                this.week = week;
                this.comm = comm;
            }
            public void showInfo()
            {
                double t = (week * (comm / 100));
                Console.WriteLine("Per week income " + week);
                Console.WriteLine("Comisiion " + t);
                Console.WriteLine("Total " + (t + week));
            }

            static void Main(string[] args)
            {

                Console.WriteLine("Enter the number of employee ");
                int numEmp = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numEmp; i++)
                {
                    Console.WriteLine("Enter the per week income & the comision percemtage:  ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    double z = Convert.ToDouble(Console.ReadLine());
                    total t = new total(y, z);
                    t.showInfo();


                }
                Console.ReadKey();

            }
        }
    }
}
