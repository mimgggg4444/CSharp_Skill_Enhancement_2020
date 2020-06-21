using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(Car.EGasType.Diesel, 10000000);

            int newPrice;
            int.TryParse(Console.ReadLine(), out newPrice);
            myCar.SetPrice(newPrice);

            float remainingFuel = myCar.GetGas();
            Console.WriteLine($"Remaining fuel: {remainingFuel}L");

        }
    }
}
