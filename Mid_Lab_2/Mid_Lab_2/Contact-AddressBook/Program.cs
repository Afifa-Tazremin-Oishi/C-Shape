//A C# Program to store and show contacts on an Addressbook.
using System;

namespace Contact_AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact C1 = new Contact();
            C1.PersonName = "Ratul";
            C1.PersonId = "19-40642-1";
            C1.MobileNumber = "01622165822";
            C1.Age = 20;
            C1.Gender = 'M';

            Contact C2 = new Contact("Sharin", "19-78787-1", 19, "01782187343", 'F');

            Contact C3 = new Contact();
            C3.PersonName = "Anik";
            C3.PersonId = "19-40779-1";
            C3.MobileNumber = "01577778889";
            C3.Age = 30;
            C3.Gender = 'M';

            //C1.ShowPersonInfo();
            //C1.DetectMobileOperator();
            //C2.ShowPersonInfo();
            //C2.DetectMobileOperator();

            AddressBook A1 = new AddressBook("Mahmodul Kabir", "Friends Info");
            A1.AddContact(C1);
            A1.AddContact(C2);
            A1.AddContact(C3);
            A1.ShowAllContactInfo();
            A1.DeleteContact(C1);
            A1.ShowAllContactInfo();
        }
    }
}
//Program Contributed by Mahmodul Ratul.