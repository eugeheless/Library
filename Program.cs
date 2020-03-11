using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStore bs = new BookStore();
            Bookshelf bsh = new Bookshelf();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 или 2 или 3 или 4");
                int q = Convert.ToInt32(Console.ReadLine());
                if (q == 1)
                {
                    Console.WriteLine("Введите название полки");
                    string name = Console.ReadLine();
                    bs.AddShelf(new Bookshelf(name));
                }
                if (q == 2)
                {
                    Console.WriteLine("Введите название книги");
                    string bookName = Console.ReadLine();
                    bsh.AddBook(new Book(bookName));
                }
                if(q == 3)
                {
                    Console.WriteLine("Вывод полок");
                    bs.ShowShelf();
                }
                if(q == 4)
                {
                    Console.WriteLine("Вывод книг");
                    bsh.ShowBooks();
                }


                Console.ReadLine();
            }
            
        }
        
    }
}
