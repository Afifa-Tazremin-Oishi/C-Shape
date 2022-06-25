//A C# Program to store and show contacts on an Addressbook.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_AddressBook
{
    class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender; // M or F

        public Contact()
        {

        }

        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }

        public string PersonName
        {
            set
            {
                this.personName = value;
            }
            get
            {
                return this.personName;
            }
        }
        public string PersonId
        {
            set
            {
                this.personId = value;
            }
            get
            {
                return this.personId;
            }
        }
        public int Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }
        public string MobileNumber
        {
            set
            {
                this.mobileNumber = value;
            }
            get
            {
                return this.mobileNumber;
            }
        }
        public char Gender
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return this.gender;
            }
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Name Of the Person : " + PersonName);
            Console.WriteLine("ID Of the Person   : " + PersonId);
            Console.WriteLine("Age Of the Person  : " + Age);
            Console.WriteLine("Mobile Number      : +88" + MobileNumber);
            Console.WriteLine("Person's Gender    : " + Gender);
            DetectMobileOperator();
        }
        public void DetectMobileOperator()// it will show GP or Robi etc.
        {
            string s1 = "17", s2 = "18", s3 = "19", s4 = "15", s5 = "16", s6 = "11";
            string S = MobileNumber.Substring(1, 2);
            if (S == s1)
            {
                Console.WriteLine("Mobile Operator is GrameenPhone.\n");
            }
            else if (S == s2)
            {
                Console.WriteLine("Mobile Operator is Robi.\n");
            }
            else if (S == s3)
            {
                Console.WriteLine("Mobile Operator is Banglalink.\n");
            }
            else if (S == s4)
            {
                Console.WriteLine("Mobile Operator is Teletalk.\n");
            }
            else if (S == s5)
            {
                Console.WriteLine("Mobile Operator is Airtel.\n");
            }
            else if (S == s6)
            {
                Console.WriteLine("Mobile Operator is Citycell.\n");
            }
            else
                Console.WriteLine("Mobile number is not recognized valid.\n");
        }
    }
}
//Program Contributed by Mahmodul Ratul.
