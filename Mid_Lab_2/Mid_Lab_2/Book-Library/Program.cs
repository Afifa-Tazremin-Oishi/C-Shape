// A C# Program to simulate Book-Library Relation operation among Book - Library objects.
using System;

namespace Book_Library
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        static int bookCounter = 0;
        public Book()
        {
            bookCounter++;
        }
        public string BookName //Property
        {
            set
            {
                {
                    this.bookName = value;
                }
            }
            get
            {
                return this.bookName;
            }
        }
        public string BookAuthor //Property
        {
            set
            {
                {
                    this.bookAuthor = value;
                }
            }
            get
            {
                return this.bookAuthor;
            }
        }
        public string BookId //Property
        {
            set
            {
                {
                    this.bookId = value;
                }
            }
            get
            {
                return this.bookId;
            }
        }
        public string BookType //Property
        {
            set
            {
                {
                    this.bookType = value;
                }
            }
            get
            {
                return this.bookType;
            }
        }
        public int BookCopy //Property
        {
            set
            {
                {
                    this.bookCopy = value;
                }
            }
            get
            {
                return this.bookCopy;
            }
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            bookCounter++;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Book name: "+BookName);
            Console.WriteLine("Author: " + BookAuthor);
            Console.WriteLine("Book ID: " + BookId);
            Console.WriteLine("Book Type: " + BookType);
            Console.WriteLine("Book Copy: " + BookCopy);
        }
        public void addBookCopy(int num)
        {
            BookCopy = BookCopy + num;
            Console.WriteLine(num+"Copy added.");
        }

        public static void totalBookInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Total Books: " +bookCounter);
            Console.WriteLine();
        }
    }


    class Library
    {
        private string libName;
        private string libAddress;
        private int totalBook = 0;
        public Library()
        {
            
        }
        public string LibName //Property
        {
            set
            {
                {
                    this.libName = value;
                }
            }
            get
            {
                return this.libName;
            }
        }
        public string LibAddress //Property
        {
            set
            {
                {
                    this.libAddress = value;
                }
            }
            get
            {
                return this.libAddress;
            }
        }
        public int TotalBook //Property
        {
            get
            {
                return this.totalBook;
            }
        }

        public Library (string libName, string libAddress)
        {
            this.libName = libName;
            this.libAddress = libAddress;
        }

        private Book[] listOfBook = new Book[1000];
        public void ShowLibInfo()
        {
            Console.WriteLine("Library name: " + LibName);
            Console.WriteLine("Address: " + LibAddress);
            Console.WriteLine("Total Books: " + TotalBook);

            Console.WriteLine("The Books collection showing bellow:\n");
            for (int i = 0; listOfBook[i] != null; i++)
            {
                Console.WriteLine("Book "+(i + 1)+":");
                listOfBook[i].ShowInfo();
                Console.WriteLine();
            }
        }
        
        public void AddNewBook(Book book)
        {
            if (listOfBook[0] == null)
            {
                listOfBook[0] = book;
                totalBook++;
            }
            else
            {
                for (int i = 0; listOfBook[i] != null; i++)
                {
                    if (listOfBook[i + 1] == null)
                    {
                        listOfBook[i + 1] = book;
                        totalBook++;
                        break;
                    }
                }
            }
        }

        public void DeleteBook(Book book)
        {
            for (int i = 0; listOfBook[i] != null; i++)
            {
                if (listOfBook[i].Equals(book))
                {
                    for (int j = i; listOfBook[j] != null; j++)
                    {
                        listOfBook[j] = listOfBook[j + 1];
                    }
                    totalBook--;
                }
            }
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] == book)
                {
                    book.BookCopy = book.BookCopy + copy;
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book B1 = new Book();
            Book B2 = new Book("Electronic Device", "Albert Halk", "456-67", "Electrical Engineering",45) ;
            Book B3 = new Book();
            Book B4 = new Book("Object Oriented Concept with C#", "Robert wiki", "230-89", "Computer Engineering", 20);

            B1.BookName = "Fundamentals of Calculus";
            B1.BookAuthor = "Robert Michel";
            B1.BookId = "34-6789";
            B1.BookType = "Mathematics";
            B1.BookCopy = 60;
            //B1.ShowInfo();
            //B1.addBookCopy(30);
            //B2.ShowInfo();
            //B2.addBookCopy(5);

            B3.BookName = "Object Oriented Concepts";
            B3.BookAuthor = "john Wrick";
            B3.BookId = "38-059";
            B3.BookType = "Computer Engineering";
            B3.BookCopy = 10;
            //B3.ShowInfo();
            //B3.addBookCopy(15);
            //Book.totalBookInfo();
            //B1.ShowInfo();
            //B2.ShowInfo();
            //B3.ShowInfo();

            Library L1 = new Library("AIUB", "Dhaka, Bangladesh");
            L1.AddNewBook(B1);
            L1.AddNewBook(B3);
            L1.AddNewBook(B2);
            L1.AddNewBook(B4);
            L1.ShowLibInfo();
            L1.DeleteBook(B3);
            L1.ShowLibInfo();
            L1.AddNewBookCopy(B3, 4);
            L1.AddNewBookCopy(B2, 5);
            L1.ShowLibInfo();
        }
    }
}
//Program Contributed by Mahmodul Ratul.