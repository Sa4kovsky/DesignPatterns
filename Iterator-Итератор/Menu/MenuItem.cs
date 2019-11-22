using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Итератор.Menu
{
    public class MenuItem
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public double Price { get; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }
    }
}
