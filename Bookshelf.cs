using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Bookshelf
    {
        public string name;
        public List<Book> books;

        public Bookshelf()
        {

        }
        public Bookshelf(string name)
        {
            this.name = name;
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void ShowBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book.name);
            }
        }
    }
}
