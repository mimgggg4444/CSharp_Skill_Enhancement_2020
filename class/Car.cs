using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace class1
{
    public class Car
    {
        public int Price = 50000;
        public float Gas;       //자동으로 0이 대입됨
        public string Owner;

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

            Console.WriteLine($"Move!\n(Gas: {Gas}L left)");
        }
        public void Honk()
        {
            Console.WriteLine("Hock~ Hock~");
        }
    

    }

}
