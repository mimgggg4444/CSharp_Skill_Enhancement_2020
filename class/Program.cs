using class1;
using System;
using System.Xml.Serialization;

namespace classPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Owner = "Kims";
            Console.WriteLine(car);

        }
    }
}
