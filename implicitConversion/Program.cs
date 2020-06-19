using System;

namespace implicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1 = 100000;
            long num2 = num1;
            */

            /*
            int num1 = 1234567890;
            float num2 = num1;

            Console.WriteLine(num1 - (int)num2);
            */

            /*
            double num1 = 10.9;
            double num2 = 52.16;
            Console.WriteLine("addition result :" + (num1 + num2));

            int result = (int)num1 + (int)num2;
            Console.WriteLine($"{result}");
            */

            long num1 = 9223372036854775807;
            int num2 = (int)num1;

            double num3 = 10.9;
            int num4 = (int)num3;
        }
    }
}
