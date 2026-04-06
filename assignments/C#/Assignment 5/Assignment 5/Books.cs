using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Books
    {
        public string BookName;
        public string AuthorName;
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine("Book: " + BookName + ", Author: " + AuthorName);
        }
    }

    public class BookShelf
    {
        private Books[] bookList = new Books[5];
        public Books this[int index]
        {
            get
            {
                return bookList[index];
            }
            set
            {
                bookList[index] = value;
            }
        }
    }
}
