//A C# Program to do the basic operations of a mobile phone.
using System;

namespace Mobile
{
    class Mobile
    {
        private string mobileOwnerName;
        private string mobileNumber;
        private string mobileBalance;
        private string mobileOSName;
        private bool Lock;
        public Mobile()
        {

        }

        public string MobileOwnerName
        {
            get
            {
                return this.mobileOwnerName;
            }
            set
            {
                this.mobileOwnerName = value;
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
                this.mobileNumber = value;
            }
        }

        public string MobileBalance
        {
            get
            {
                return this.mobileBalance;
            }
            set
            {
                this.mobileBalance = value;
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
                this.mobileOSName = value;
            }
        }

        public bool Locked
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
        public Mobile(string mown, string mn, string mb, string mosn, bool L)
        {
            this.mobileOwnerName = mown;
            this.mobileNumber = mn;
            this.mobileOSName = mosn;
            this.mobileBalance = mb;
            this.Lock = L;
        }

        public void ShowInfo()
        {
            if (Locked == true)
            {
                Console.WriteLine("Can not show Information of this Mobile. It is locked.\n");
            }
            else if (Locked == false)
            {
                Console.WriteLine("Owner of the Mobile : " + MobileOwnerName);
                Console.WriteLine("Mobile Number       : " + MobileNumber);
                Console.WriteLine("Operating System    : " + MobileOSName);
                Console.WriteLine("Balance             : " + MobileBalance);
                Console.WriteLine("Lock Status         : " + Locked);
                Console.WriteLine();
            }
        }

        public void CallSomeone(int timeDuration)
        {
            if (Locked == true)
            {
                Console.WriteLine("Can not make a call. This Mobile is locked.\n");
            }
            else if (Locked == false)
            {
                if (timeDuration < Convert.ToInt32(MobileBalance))
                {
                    Console.WriteLine("Calling ... ... ...\n");
                }
                else
                    Console.WriteLine("Out of balance.!!  Could not make a call.\n");
            }
        }

        public void Recharge(int amount)
        {
            if (Lock == true)
            {
                Console.WriteLine("Can not recharge. This Mobile is locked.\n");
            }
            else if (Locked == false)
            {
                MobileBalance = Convert.ToString(Convert.ToInt32(MobileBalance)+ amount);
                Console.WriteLine("Recharged by " + amount + " Taka Successfully.\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mobile M1 = new Mobile ("Ratul", "+8801622-165822", "40", "Android", true);
            Mobile M2 = new Mobile ("Baitul", "+8801537-207512", "10", "Java", false);

            Mobile M3 = new Mobile();
            M3.MobileOwnerName = "Akash";
            M3.MobileNumber = "+8801982-187343";
            M3.MobileBalance = "10";
            M3.MobileOSName = "Java";
            M3.Locked = true;

            M1.CallSomeone(5);
            M1.Recharge(10);
            M1.ShowInfo();

            M2.Recharge(10);
            M2.CallSomeone(10);
            M2.ShowInfo();

            M3.CallSomeone(5);
            M3.Recharge(10);
            M3.ShowInfo();

        }
    }
}
// Program Contributed by Mahmodul Ratul.