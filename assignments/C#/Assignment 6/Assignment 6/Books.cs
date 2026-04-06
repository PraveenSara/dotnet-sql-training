using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Books
    {
        string BookName, AuthorName;
        
        public Books(string BName, string AName)
        {
            BookName = BName;
            AuthorName = AName;
        }
        internal void Display()
        {
            Console.WriteLine("Book : " + BookName + " Author : " + AuthorName);
        }
    }
    internal class BookShelf
    {
        Books[] books = new Books[5];
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }
}
