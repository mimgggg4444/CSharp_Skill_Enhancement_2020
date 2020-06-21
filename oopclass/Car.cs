using System;
using System.Collections.Generic;
using System.Text;

namespace oopclass
{
    class Car
    {
        public int Price = 50000;
        public float Gas;
        public string Owner;

        public Car(string owner)
        {
            Owner = owner;
        }

        public void Move()
        {
            Gas -= 0.5f;
            Console.WriteLine($"Move!\n(Gas: {Gas}L left)");
        }

        public void Honk()
        {
            Console.WriteLine("Honk~");
        }
    }
}
