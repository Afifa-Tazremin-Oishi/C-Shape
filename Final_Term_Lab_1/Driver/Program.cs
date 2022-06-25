using System;
namespace trip_history
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveHistory d1 = new DriveHistory();
            Console.Write("Enter Trip ID number: ");
            d1.TripNumber = Console.ReadLine();
            Console.Write("Enter Miles Driven: ");
            d1.MilesDriven = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Used Gallons: ");
            d1.UsedGallons = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            d1.ShowDriveHistory();
            d1.MilesPerGallon();
        }
    }
}

