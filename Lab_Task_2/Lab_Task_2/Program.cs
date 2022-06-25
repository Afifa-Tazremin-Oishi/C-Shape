using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Books
{
    class Book
    {


        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        private static int bookCounter = 0;



        public Book()
        {

        }

        public Book(string n, string a, string i, string t, int c, int b)
        {
            bookName = n;
            bookAuthor = a;
            bookId = i;
            bookType = t;
            bookCopy = c;
            bookCounter++;
        }
        public string BookName
        {
            get
            {
                return this.bookName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid book name!!!!");
                }
                else
                {
                    this.bookName = value;
                }

            }
        }


        public string BookAuthor
        {
            get
            {
                return this.bookAuthor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid author name!!!!");
                }
                else
                {
                    this.bookAuthor = value;
                }

            }
        }
        public string BookId
        {
            get
            {
                return this.bookId;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid book id !!!!");
                }
                else
                {
                    this.bookId = value;
                }

            }
        }
        public string BookType
        {
            get
            {
                return this.bookType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid book type !!!!");
                }
                else
                {
                    this.bookType = value;
                }
            }
        }
        public int BookCopy
        {
            get
            {
                return this.bookCopy;
            }
            set
            {
                this.bookCopy = value;
            }
        }


        public int BookCounter
        {
            get
            {
                return bookCounter;
            }
            set
            {
                bookCounter = value;
            }
        }



        public void ShowInfo()
        {
            Console.WriteLine("Details of a particular Book");
            Console.WriteLine("Book’s Name :" + bookName);
            Console.WriteLine("Author of the book:" + bookAuthor);
            Console.WriteLine("Id of the book:" + bookId);
            Console.WriteLine("Type of Book:" + bookType);
            Console.WriteLine("Book Copy:" + bookCopy);
        }





        void AddBookCopy(int x)
        {
            bookCopy = bookCopy + x;
            bookCounter = bookCounter + x;
        }






        static void showTotalBookInfo()
        {
            Console.WriteLine("Total Number of Books:" + bookCounter);
        }





        public static void Main()
        {



            Book b1 = new Book();
            b1.bookName = "Sacred Duty";
            b1.bookAuthor = "Cotton";
            b1.bookType = "Biography";
            b1.bookId = "NDFEG001";
            b1.AddBookCopy(30);
            b1.ShowInfo();
            Book.showTotalBookInfo();
            Console.ReadKey();





        }
    }
}