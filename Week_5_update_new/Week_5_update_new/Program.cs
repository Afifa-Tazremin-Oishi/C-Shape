using System;

namespace Book
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        public string BookName
        {
            set 
            { 
                bookName = value; 
            }
            get 
            {
                return bookName; 
            }
        }

        public string BookAuthor
        {
            get 
            { 
                return bookAuthor; 
            }
            set 
            { 
                bookAuthor = value; 
            }
        }


        public string BookId
        {
            get 
            { 
                return bookId; 
            }
            set
            {
                bookId = value; 
            }
        }


        public string BookType
        {
            get 
            { 
                return bookType; 
            }
            set
            {
                bookType = value; 
            }
        }


        public int BookCopy
        {
            get 
            { 
                return bookCopy;
            }
            set 
            { 
                bookCopy = value;
            }
        }


        public Book()
        {
            Console.WriteLine("Book Empty Constructor");
        }

        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            

        }

        public void ShowInfo()
        {
            Console.WriteLine("Book Name   :  " + bookName);
            Console.WriteLine("Book Author :  " + bookAuthor);
            Console.WriteLine("Book ID     :  " + bookId);
            Console.WriteLine("Book Type   :  " + bookType);
            Console.WriteLine("Book Copy   :  " + bookCopy);
        }

        public void addBookCopy(int x)
        {
            bookCopy = bookCopy + x;
            Console.WriteLine("Book Copy   : " + x);
            bookCounter = bookCopy;
        }

        public static int bookCounter;
        public static void showTotalBookInfo()
        {
            Console.WriteLine("Total Book  : " + bookCounter);
        }

        class Library
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

            public Library()
            {
                Console.WriteLine("Empty Library");
            }
            public Library(string libName, string libAddress)
            {
                this.libName = libName;
                this.libAddress = libAddress;
            }

            private Book[] listOfBook = new Book[1000];

            public void ShowLibInfo()
            {
                Console.WriteLine("Library Name : " + LibName);
                Console.WriteLine("Address      : " + LibAddress);
                Console.WriteLine("Total Books  : " + TotalBook);

                Console.WriteLine("\nThe List of Books showing below:\n");

                for (int i = 0; listOfBook[i] != null; i++)
                {
                    Console.WriteLine("Book " + (i + 1) + ":");
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
                Book obj1 = new Book("AAAAAAAA", "ABC", "123456", "XXX", 15);
                Book obj2 = new Book("BBBBBBB", "DEF", "654321", "YYY", 20);
                Book obj3 = new Book("CCCCCCC", "GHI", "098765", "ZZZ", 32);
             

                Library L = new Library("Dinajpur Library", "Dinajpur");
                Console.WriteLine();
                Console.WriteLine("Adding Books on Library");
                L.AddNewBook(obj3);
                L.AddNewBook(obj1);
                L.AddNewBook(obj2);
                L.ShowLibInfo();
                Console.WriteLine();
                Console.WriteLine("After Deletion of a book slot");
                L.DeleteBook(obj3);
                L.ShowLibInfo();
                Console.WriteLine();
                Console.WriteLine("Adding some copies on library");
                L.AddNewBookCopy(obj1, 3);
                L.AddNewBookCopy(obj3, 4);
                L.ShowLibInfo();
                Console.ReadKey();
            }
        }
    }
}

