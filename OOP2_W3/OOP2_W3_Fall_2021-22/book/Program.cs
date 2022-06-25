using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {

        class Book
        {

            private string bookName;
            private string bookAuthor;
            private string bookId;
            private string bookType;
            private int bookCopy;


            public string BOOKNAME { set; get; }
            public string BOOKAUTHOR { set; get; }
            public string BOOKID { set; get; }
            public string BOOKTYPE { set; get; }
            public int BOOKCOPY { set; get; }


            public Book()
            {
                Console.WriteLine("Empty constructor");
            }

            public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookId = bookId;
                this.bookType = bookType;
                this.bookCopy = bookCopy;
            }


            public void showInfo()
            {
                Console.WriteLine("Book Name : " + bookName);
                Console.WriteLine("Book Author: " + bookAuthor);
                Console.WriteLine("Book Id: " + bookId);
                Console.WriteLine("Book type: " + bookType);
                Console.WriteLine("Book copy: " + bookCopy);
                Console.WriteLine("---------------------");

            }
            public void addBookCopy(int x)
            {
                bookCopy = bookCopy + x;
                Console.WriteLine("Book Copy: " + x);
                bookCount = bookCopy;
            }
            public static int bookCount;
            public static void showTotalBook()
            {
                Console.WriteLine("Total BOOK: " + bookCount);
            }


            static void Main(string[] args)
            {


                string nowDateTime = "Date : " + DateTime.Now.ToString();
                Console.WriteLine(nowDateTime);
                Console.WriteLine();
                Book b1 = new Book("Celestial Bodies", "Jokha Alharthi", "1FF6HH", "History", 12);
                b1.showInfo();

                b1.addBookCopy(10);

                Console.ReadKey();

            }
        }
    }
}
