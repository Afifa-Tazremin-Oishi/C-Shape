using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Mobiles
{
    class Mobile
    {
        private string mobileOwnerName;
        private string mobileNumber;
        private double mobileBalance;
        private string mobileOSName;
        private bool Lock;
        public Mobile()
        {

        }
        public Mobile(string name, string num, double balance, string os, bool lo)
        {
            mobileOwnerName = name;
            mobileNumber = num;
            mobileBalance = balance;
            mobileOSName = os;
            Lock = lo;
        }


        public void ShowInfo()
        {
            Console.WriteLine("Mobile’s OwnerName:" + mobileOwnerName);
            Console.WriteLine("Mobile Number:" + mobileNumber);
            Console.WriteLine("Mobile Balance:" + mobileBalance);
            Console.WriteLine("Mobile OS Name :" + mobileOSName);





        }


        public string MobileOwnerName
        {
            get
            {
                return this.mobileOwnerName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid name!!!!");
                }
                else
                {
                    this.mobileOwnerName = value;
                }

            }
        }


        public string MobileNumber
        {
            get
            {
                return this.mobileNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid number!!!!");
                }
                else
                {
                    this.mobileNumber = value;
                }




            }
        }
        public double MobileBalance
        {
            get
            {
                return this.mobileBalance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid blance value!!!!");
                }
                else
                {
                    this.mobileBalance = value;
                }

            }
        }
        public string MobileOSName
        {
            get
            {
                return this.mobileOSName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Os name!!!!");
                }
                else
                {
                    this.mobileOSName = value;
                }

            }
        }
        public Boolean Locka
        {
            get
            {
                return this.Lock;
            }
            set
            {
                this.Lock = value;
            }
        }






        public void Recharge(int amount)
        {
            if (Lock == false)
            {
                mobileBalance = amount + mobileBalance;
                Console.WriteLine("Mobile recharge :"+ amount);
                Console.WriteLine("Balance After Recharge : " + mobileBalance);
            }
            else
            {
                Console.WriteLine("The Device is Locked.");
            }
        }




        public void CallSomeone(int timeDuration)
        {
            if (Lock == false)
            {
                double cost = 0;
                cost = timeDuration * 0.8;
                Console.WriteLine("Total time duration : " + timeDuration);
                Console.WriteLine("Total cost : " + cost + " Taka");
            }
            else
            {
                Console.WriteLine("The Device is unable ");
            }


        }


        class main
        {
            static void Main(string[] args)
            {
                Mobile m = new Mobile();
                m.MobileOwnerName = "Emrul Hasan Emon";
                m.MobileNumber = "01782387758";
                m.MobileBalance = 100;
                m.MobileOSName = "Android";
                m.Lock = false;
                m.ShowInfo();
                m.Recharge(300);
                m.CallSomeone(5);
               Console.ReadKey();
            }
        }


    }


}