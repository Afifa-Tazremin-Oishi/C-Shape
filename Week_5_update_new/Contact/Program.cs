using System;

namespace Contact
{
    class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;
        public string Name
        {
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
            get
            {
                return this.personName;
            }
        }
        public string Id
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid number!!!!");
                }
                else
                {
                    this.personId = value;
                }



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
                if (value <= 0)
                {
                    Console.WriteLine("Invalid age value!!!!");
                }
                else
                {
                    this.age = value;
                }



            }
            get
            {
                return this.age;
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
        public string Number
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
        public Contact(string personName, string personId, int age, string mobileNumber, char
        gender) //paraconstructor
        {
            this.Name = personName;
            this.Id = personId;
            this.Age = age;
            this.Number = mobileNumber;
            this.Gender = gender;
        }
        public Contact()
        {



        }
        public void ShowPersonalInfo()
        {


            Console.WriteLine("# Contact Holder Details:");
            Console.WriteLine(" ");
            Console.WriteLine(" Name of the person is : {0} ", Name);
            Console.WriteLine(" His/Her Id is : {0} ", Id);
            Console.WriteLine(" His/Her age is : {0} ", Age);
            Console.WriteLine(" His number : " + mobileNumber);



            Console.WriteLine(" His gender : {0}", Gender);
            Console.WriteLine(" ");



        }
        public void DetectMobileOperator()
        {
            if (mobileNumber[2].Equals('7'))
            {
                Console.WriteLine("Operator name : GP");
                Console.WriteLine("");

            }
            else if (mobileNumber[2].Equals('8'))
            {
                Console.WriteLine("Operator name : Robi");
                Console.WriteLine("");

            }
            else if (mobileNumber[2].Equals('1'))
            {
                Console.WriteLine("Operator name : Citycell");
                Console.WriteLine("");

            }
            else if (mobileNumber[2].Equals('5'))
            {
                Console.WriteLine("Operator name : Teletalk");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("Error entry");
                Console.WriteLine("");

            }
        }
        class AddressBook
        {
            private string libName;
            private string libAddress;
            private int totalBook = 0;



            public string LibName
            {
                set { libName = value; }
                get { return libName; }
            }
            public string LibAddress
            {
                set { libAddress = value; }
                get { return libAddress; }
            }
            public int TotalBook
            {
                get { return totalBook; }
            }



            public AddressBook()
            {
                Console.WriteLine("Empty Library");
            }
            public AddressBook(string libName, string libAddress)
            {
                this.libName = libName;
                this.libAddress = libAddress;
            }



            private Contact[] listOfCon = new Contact[1000];



            public void ShowLibInfo()
            {
                Console.WriteLine("Area Name : " + LibName);
                Console.WriteLine("Address : " + LibAddress);
                Console.WriteLine(" ");
                Console.WriteLine("***Total contacts : " + TotalBook);




            }



            public void AddNewBook(Contact number)
            {
                if (listOfCon[0] == null)
                {
                    listOfCon[0] = number;
                    totalBook++;
                }
                else
                {
                    for (int i = 0; listOfCon[i] != null; i++)
                    {
                        if (listOfCon[i + 1] == null)
                        {
                            listOfCon[i + 1] = number;
                            totalBook++;
                            break;
                        }
                    }
                }
            }



            public void DeleteContact(Contact book)
            {
                for (int i = 0; listOfCon[i] != null; i++)
                {
                    if (listOfCon[i].Equals(book))
                    {
                        for (int j = i; listOfCon[j] != null; j++)
                        {
                            listOfCon[j] = listOfCon[j + 1];
                        }
                        totalBook--;
                    }
                }
            }





        }
        class program
        {
            static void Main(string[] args)
            {



                Contact C2 = new Contact("Emrul Hasan", "100456A", 21, "0179XXX758", 'M');
                Contact C3 = new Contact("Mithila ", "1FF456A", 21, "019907547758", 'F');
                 C2.ShowPersonalInfo();
                C2.DetectMobileOperator();



                AddressBook L = new AddressBook("Dhaka(Badda)", "2021A Aftab nogor");
                Console.WriteLine("Adding a New Contact information");
                L.AddNewBook(C2);

                C2.ShowPersonalInfo();
                C2.DetectMobileOperator();
                L.AddNewBook(C3);

                C3.ShowPersonalInfo();
                C3.DetectMobileOperator();
                L.ShowLibInfo();
                Console.WriteLine("After Deletion of a Contact information");
                L.DeleteContact(C2);
                L.ShowLibInfo();
                Console.WriteLine(" ");
                Console.ReadKey();



            }
        }
    }
}