using System;

namespace increaseDecrementOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            char ch = 'b';//0x62

            ++ch;
            Console.WriteLine(ch);

            --ch;
            --ch;
            --ch;

            Console.WriteLine(ch);


        }
    }
}
