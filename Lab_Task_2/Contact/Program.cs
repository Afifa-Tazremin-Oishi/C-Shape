using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contacts
{
    class Contact
    {
        private string personName;
        private string personId;
        private string mobileNumber;
        private int age;
        private char gender;

        public Contact()
        {

        }
        public Contact(string n, string i, int a, string nu, char g)
        {
            personName = n;
            personId = i;
            age = a;
            mobileNumber = nu;
            gender = g;
        }

        public string PersonName
        {
            get
            {
                return this.personName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid name!!!!");
                }
                else
                {
                    this.personName = value;
                }

            }
        }


        public string PersonId
        {
            get
            {
                return this.personId;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Id !!!!");
                }
                else
                {
                    this.personId = value;
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
                    Console.WriteLine("Invalid number !!!!");
                }
                else
                {
                    this.mobileNumber = value;
                }

            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid age value!!!!");
                }
                else
                {
                    this.age = value;
                }
            }

        }


        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Person’s Name:" + personName);
            Console.WriteLine("Person’s Id :" + personId);
            Console.WriteLine("Age :" + age);
            Console.WriteLine("Mobile Number :" + mobileNumber);
            Console.WriteLine("Gender :" + gender);



        }




        public void DetectMobileOperator()
        {
            if (mobileNumber[2].Equals('7'))
            {
                Console.WriteLine("Operator name : GP");
            }
            else if (mobileNumber[2].Equals('8'))
            {
                Console.WriteLine("Operator name : Robi");
            }
            else if (mobileNumber[2].Equals('1'))
            {
                Console.WriteLine("Operator name : Citycell");
            }
            else if (mobileNumber[2].Equals('5'))
            {
                Console.WriteLine("Operator name : Teletalk");
            }
            else
            {
                Console.WriteLine("Error entry");
            }


        }
        class main
        {
            static void Main(string[] args)
            {


                Contact c = new Contact();
                c.personName = "Emrul Hasan Emon";
                c.personId = "101";
                c.age = 21;
                c.mobileNumber = "01782387758";
                c.gender = 'M';
                c.ShowPersonInfo();
                c.DetectMobileOperator();
                Console.ReadKey();
            }
        }
    }
}