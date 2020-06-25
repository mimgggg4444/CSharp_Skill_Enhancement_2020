using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ123
{
    class Program

    {
        static void Menu(string[]args)
        {
            var menuItems = new List<MenuItem>();
            var filteredItems = MenuItem.Where

            foreach(MenuItem item in filteredItems)
            {
                Console.WriteLine($"ID({item.ID}), Name({item.Name}), Price({item.Price})");
            }
        }
    }
}
