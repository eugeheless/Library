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

            Console.WriteLine("Добавить секцию");
            Section section = new Section(Console.ReadLine());
            sections.Add(section);
            Console.WriteLine("Done");
            Console.WriteLine("2");
            Section section1 = new Section(Console.ReadLine());
            sections.Add(section1);
            Console.WriteLine("Vivod");
            //foreach(Section s in sections)
            //    Console.WriteLine(s.name);




            Console.WriteLine("Имя полки");
            section1.AddShelf(Console.ReadLine());
            Console.WriteLine("Имя полки2");
            section1.AddShelf(Console.ReadLine());
            Console.WriteLine("Имя полки3");
            section1.AddShelf(Console.ReadLine());
            Console.WriteLine("Vivod");
            section1.ShowShelf();

            




            Console.ReadLine();
        }

    }
}
