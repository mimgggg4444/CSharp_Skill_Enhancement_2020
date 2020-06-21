using System;

namespace property
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car(Car.EGasType.Diesel, 1000000);
            mycar.Owner = "kim";
            mycar.Price = 6500000;
            mycar.FillUp(100.0f);
            Console.WriteLine(mycar.Price);
            mycar.Move();
            mycar.Move();
            mycar.honk();

        }
    }
}
