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



            Car mycar = new Car(Car.EGasType.Diesel, 1000000);
            int newPrice;
            Console.WriteLine("Hello?");
            int.TryParse(Console.ReadLine(), out newPrice);
            mycar.SetPrice(newPrice);

            float remainingFulel = mycar.GetGas();
            Console.WriteLine($"Remaining fuel: {remainingFulel}L");




            // float remaingFuel = mycar.mGas; Due to the level of protection, the fuel level is unknown.

        }
    }
}
