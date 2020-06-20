using System;

namespace recursiveFunction1
{
    class Program
    {
        static uint SumRecursive(uint num)
        {
            if(num == 0)
            {
                return 0;
            }
            else
            {
                return num + SumRecursive(num - 1);
            }
        }

        public static int FibonacciRecursive(uint number)
        {
            if(number == 0)
            {
                return 0;
            }
            if(number == 1)
            {
                return 1;
            }

            return FibonacciRecursive(number - 2) + FibonacciRecursive(number - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SumRecursive(100));
        }
    }
}
