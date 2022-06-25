
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Contact
    {
        private String personName;
        private String personId;
        private int age;
        private String mobileNumber;
        private char gender;

        public Contact(String personName, String personId, int age, String mobileNumber, char gender)
        {
            this.personName = personName;

            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        public Contact()
        {

        }
        public string PersonName
        {

            set
            {
                personName = value;
            }
            get
            {
                return personName;
            }
        }
        public string PersonId
        {

            set
            {
                personId = value;
            }
            get
            {
                return personId;
            }
        }
        public int Age
        {

            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public string MobileNumber
        {

            set
            {
                mobileNumber = value;
            }
            get
            {
                return mobileNumber;
            }
        }
        public char Gender
        {

            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        public void detectMobileOperator()
        {
            String str = mobileNumber;


            if (mobileNumber[2] == '7')
            {
                Console.WriteLine("GP ");
            }
            if (mobileNumber[2] == '8')
            {
                Console.WriteLine("Robi ");
            }
            if (mobileNumber[2] == '6')
            {
                Console.WriteLine("Airtel ");
            }
            if (mobileNumber[2] == '9')
            {
                Console.WriteLine("Banglalink ");
            }
            if (mobileNumber[2] == '5')
            {
                Console.WriteLine("Telitalk ");
            }
        }
        public void showInfo()
        {
            Console.WriteLine("Person Info :" + personName);
            Console.WriteLine("Person Name :" + personId);
            Console.WriteLine("Person ID :" + age);
            Console.WriteLine("Person age :" + age);
            Console.WriteLine("Person mobileNumber :" + mobileNumber);
            Console.WriteLine("Person gender :" + gender);

        }
    }
    class AdressBook : Contact
    {
        private String ownerName;
        private String ownerinfo;
        public AdressBook()
        {
           // Console.WriteLine(" Inheretance ");
        }



    }
    public class main
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact();
            Contact[] c3 = new Contact[100];
            for (int i = 0; i < 100; i++)
            {
                c3[i] = new Contact();
            }
            AdressBook a1 = new AdressBook();


           
            c3[0].PersonName = "Emrul Hasan";
            c3[0].PersonId = "1234GT";
            c3[0].Age = 22;
            c3[0].MobileNumber = "01782387758";
            c3[0].Gender = 'M';
            c3[0].showInfo();
            c3[0].detectMobileOperator();
            Console.ReadKey();

        }
    }
}

