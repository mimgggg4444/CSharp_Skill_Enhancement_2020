using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            double centimeters = UnitConverter.GetCentimetersFromInches(1.24);

            Console.WriteLine(centimeters);
        }
    }
}
