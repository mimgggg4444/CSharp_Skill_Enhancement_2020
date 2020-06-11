using System;

namespace RecursiveFunction
{
    class Program
    {
        static uint SumRecursive(uint num)
        {
            if(num == 0)
            {
                return 0;       ///early exit
            }
            else
            {
                return num + SumRecursive(num - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumRecursive(123151));

        }
    }
}
