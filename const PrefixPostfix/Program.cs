using System;

namespace const_PrefixPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0b10;
            int num2 = 0B10;

            int num3 = 0x10;
            int num4 = 0X10;

            int num5 = 10;
            uint num6 = 10u;
            uint num7 = 0x10u;

            long num8 = 10l;
            ulong num9 = 10lu;

            float num10 = 10.0f;
            double num11 = 11.0d;

            Console.WriteLine(num7);

        }
    }
}
