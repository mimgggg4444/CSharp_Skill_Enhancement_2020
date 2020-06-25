using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ123
{
    class MenuItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public MenuItem(int id, string name, float price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        
    }
}
