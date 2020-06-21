using System;

namespace oopclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("kim");
            mycar.Gas = 50.0f;
            mycar.Move();
            mycar.Honk();

        }
    }
}
