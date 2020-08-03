using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int result1 = num1 << 1;
            Console.WriteLine("result1: " + result1);

            int result22 = num1 << 2;
            Console.WriteLine("result2: " + result22);

            int result33 = result22 >> 3;
            Console.WriteLine("result3: " + result33);

            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0;
            byte mask1 = 1 << 2;
            bitFlags |= mask1;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            byte mask3 = (1 << 3) | (1 << 5);

            bitFlags |= mask3;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= (byte)~mask1;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= 0;
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            char char1 = 'A';
            int resultl = char1 | ' ';

            Console.WriteLine("result1: " + (char)result1);

            char char2 = 'a';
            int result2 = char2 & '_';

            Console.WriteLine("result2: " + (char)result2);
        }
    }
}
