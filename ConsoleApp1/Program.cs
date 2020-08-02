using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1234567890;
            float num2 = num1;

            Console.WriteLine(num1 - (int)num2);

            double num3 = 3.7;
            int num4 = 10;

            Console.WriteLine(num3 + num4);

            int in1 = -1;
            uint inttouint = (uint)in1;
            Console.WriteLine("int to uint: " + inttouint);

        }
    }
}
