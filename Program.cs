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
            List<Section> sections = new List<Section>();
            Console.WriteLine("Какое имя секции?");
            Section section = new Section(Console.ReadLine());
            sections.Add(section);
            while (true)
            {
                Console.WriteLine("Добавить полку(1), посмотреть(2), удалить(3)\nДобавить книгу(4), просмотреть(5), удалить(6)");
                string q = Console.ReadLine();
                if (q == "1")
                {
                    Console.WriteLine("Какое имя полки?");
                    section.AddShelf(Console.ReadLine());
                }
                if (q == "2")
                {
                    section.ShowShelf();
                }
                if (q == "3")
                {
                    Console.WriteLine("Введите название полки");
                    section.RemoveShelf(Console.ReadLine());
                }
                if (q == "4")
                {
                    Console.WriteLine("Какое имя книги");
                }
                if (q == "5")
                {

                }
                if (q == "6")
                {

                }
            }

        }

    }
}
