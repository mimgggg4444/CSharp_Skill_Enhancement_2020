using System;

namespace passByValue__passByReference
{
    class Program
    {
        static void Main(string[]args)
        {
            double input = 3.14;
            Square(ref input);

            Console.WriteLine($"{input}");
        }

        static void Square(ref double number)
        {
            number *= number;
        }


    }
}
