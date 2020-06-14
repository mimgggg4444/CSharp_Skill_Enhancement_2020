using class1;
using System;
using System.Xml.Serialization;

namespace classPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("kim");
            myCar.Gas = 50.0f;
            myCar.Move();
            myCar.Honk();

        }
    }
}
