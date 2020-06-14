using class1;
using System;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace classPractice
{
    class Program
    {
        static void Main(string[] args)
        {



            Car mycar = new Car(Car.EGasType.Diesel);
            mycar.Owner = "Kim";
            mycar.FillUp(50.0f);
            mycar.Move();
            mycar.Honk()

        }
    }
}
