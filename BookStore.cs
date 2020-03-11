using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookStore
    {
        public List<Bookshelf> bookshelves;

        public BookStore()
        {
            bookshelves = new List<Bookshelf>();
        }

        public void AddShelf(Bookshelf shelf)
        {
            bookshelves.Add(shelf);
        }
        public void RemoveShelf(Bookshelf shelf)
        {
            bookshelves.Remove(shelf);
        }
        public void ShowShelf()
        {
            foreach(Bookshelf sh in bookshelves)
            {
                Console.WriteLine(sh);
            }
        }
    }
}
