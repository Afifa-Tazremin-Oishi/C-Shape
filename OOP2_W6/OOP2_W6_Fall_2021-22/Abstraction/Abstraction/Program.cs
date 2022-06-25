using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Car
    {
        private string _CarName = "Honda City";
        private string _CarColur = "Black";
        public string CarName
        {
            set
            {
                _CarName = value;
            }
            get
            {
                return _CarName;
            }
        }
        public string CarColur
        {
            set
            {
                _CarColur = value;
            }
            get
            {
                return _CarColur;
            }
        }
        public void Steering()
        {
            Console.WriteLine("Streering of the Car");
        }

        public void Brakes()
        {
            Console.WriteLine("Brakes of the Car");
        }
        public void Gear()
        {
            Console.WriteLine("Gear of the Car");
        }
        private void CarEngine()
        {
            Console.WriteLine("Engine of the Car");
        }
        private void DiesalEngine()
        {
            Console.WriteLine("DiesalEngine of the Car");
        }

        private void Silencer()
        {
            Console.WriteLine("Silencer of the Car");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //Creating an instance of Car
            Car CarObject = new Car();
            //Accessing the Public Properties and methods
            string CarName = CarObject.CarName;
            string CarColur = CarObject.CarColur;
            CarObject.Brakes();
            CarObject.Gear();
            CarObject.Steering();
            //Try to access the private variables and methods
            //Compiler Error, 'Car._CarName' is inaccessible due to its protection level
            //CarObject._CarName;
            //Compiler Error, 'Car.CarEngine' is inaccessible due to its protection level
            //CarObject.CarEngine();
        }
    }

    ////////////////// Another Exmaple ///////////////////////
    /*
    public class Laptop
    {
        private string brand;
        private string model;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
        public void LaptopKeyboard()
        {
            Console.WriteLine("Type using Keyword");

        }
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotheBoard Information");
        }
        private void InternalProcessor()
        {

            Console.WriteLine("Processor Information");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Laptop l = new Laptop();
            l.Brand = "Lenovo";
            l.Model = "G40";
            l.LaptopDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }*/
}


