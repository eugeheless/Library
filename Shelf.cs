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
        public  List<Book> books { get; set; }
        public Shelf(string Name)
        {
            this.name = Name;
        }

        public void AddBook(string name)
        {
            Book book = new Book(name);
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void ShowBooks()
        {
            foreach(Book b in books)
                Console.WriteLine(b);
        }
    }
}
