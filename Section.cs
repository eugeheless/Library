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
        public List<Shelf> shelves { get; set; }
        public Section(string Name)
        {
            this.name = Name;
        }

        public void AddShelf(string name)
        {
            Shelf shelf = new Shelf(name);
            shelves.Add(shelf);
        }

        public void RemoveShelf(Shelf shelf)
        {
            shelves.Remove(shelf);
        }

        public void ShowShelf()
        {
            foreach(Shelf s in shelves)
                Console.WriteLine(s.name);
        }
    }
}
