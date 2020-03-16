using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Shelf
    {
        public string name { get; set; }
        List<Book> books;
        public Shelf()
        {
        }
        public Shelf(string Name)
        {
            this.name = Name;
            books = new List<Book>();
        }

        public void AddBook(string name)
        {
            Book book = new Book(name);
            books.Add(book);
            
        }

        public void RemoveBook(string name)
        {
            foreach (Book b in books)
            {
                if (b.name == name)
                {
                    books.Remove(b);
                    break;
                }
            }
        }

        public void ShowBooks()
        {
            foreach(Book b in books)
                Console.WriteLine(b);
        }
    }
}
