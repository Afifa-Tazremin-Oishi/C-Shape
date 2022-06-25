//A C# Program to store and show contacts on an Addressbook.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_AddressBook
{
    class AddressBook
    {
        private string ownerName;
        private string info;
        private int totalContact;
        private Contact[] listOfContact = new Contact[1000];
        public string OwnerName
        {
            set
            {
                this.ownerName = value;
            }
            get
            {
                return this.ownerName;
            }
        }

        public string Info
        {
            set
            {
                this.info = value;
            }
            get
            {
                return this.info;
            }
        }

        public int TotalContact
        {
            set
            {
                this.totalContact = value;
            }
            get
            {
                return this.totalContact;
            }
        }

        public AddressBook()
        {

        }

        public AddressBook(string ON, string info)
        {
            this.ownerName = ON;
            this.info = info;
        }

        public void ShowAllContactInfo()
        {
            Console.WriteLine("Owner's Name   : " + OwnerName);
            Console.WriteLine("Info           : " + Info);
            Console.WriteLine("Total Contacts : " + TotalContact);

            Console.WriteLine("The Contact List showing bellow:\n");
            for (int i = 0; listOfContact[i] != null; i++)
            {
                Console.WriteLine("Contact " + (i + 1) + ":");
                listOfContact[i].ShowPersonInfo();
                Console.WriteLine();
            }
        }

        public void AddContact(Contact con)
        {
            if (listOfContact[0] == null)
            {
                listOfContact[0] = con;
                TotalContact++;
            }
            else
            {
                for (int i = 0; listOfContact[i] != null; i++)
                {
                    if (listOfContact[i + 1] == null)
                    {
                        listOfContact[i + 1] = con;
                        TotalContact++;
                        break;
                    }
                }
            }
        }

        public void DeleteContact(Contact con)
        {
            for (int i = 0; listOfContact[i] != null; i++)
            {
                if (listOfContact[i].Equals(con))
                {
                    for (int j = i; listOfContact[j] != null; j++)
                    {
                        listOfContact[j] = listOfContact[j + 1];
                    }
                    TotalContact--;
                }
            }
        }
    }
}
//Program Contributed by Mahmodul Ratul.
