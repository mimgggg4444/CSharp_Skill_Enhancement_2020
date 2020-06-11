using System;

namespace FibonacciIterative
{
    class Program
    {
        
        public static uint FibonacciIterative(uint number)
        {
            if(number == 0)
            { 
                return 0;
            }

            if(number == 1)
            {
                return 1;
            }

            return FibonacciIterative(number - 2) + FibonacciIterative(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciIterative(10));
        }
    }
}
