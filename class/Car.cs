using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    public class Car
    {
        public int Price;
        public float Gas;
        public string Owner;

        public int GetPrice()
        {
            return Price;
        }
        public string GetOwner()
        {
            return Owner;
        }
        public void SetOwner(string owner)
        {
            Owner = owner;
        }
        public float GetGas()
        {
            return Gas;
        }
        public void FillUp(float gas)
        {
            Gas += gas;
        }
        public void Move()
        {
            Gas -= 0.5f;
        }
        public void Honk()
        {
            Console.WriteLine("Hock~ Hock~");
        }
    }

}
