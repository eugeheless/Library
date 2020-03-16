using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Section
    {
        public string name { get; set; }
        List<Shelf> shelves = new List<Shelf>();
        public Section(string Name)
        {
            this.name = Name;
        }

        public void AddShelf(string name)
        {
            Shelf shelf = new Shelf(name);
            shelves.Add(shelf);
        }

        public void RemoveShelf(string name)
        { 
            foreach(Shelf s in shelves)
            {
                if(s.name == name)
                {
                    shelves.Remove(s);
                    break;
                }
            }
        }

        public void ShowShelf()
        {
            foreach(Shelf s in shelves)
                Console.WriteLine(s.name);
        }
    }
}
