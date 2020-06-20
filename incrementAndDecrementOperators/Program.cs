using System;

namespace incrementAndDecrementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 10;

            int result1 = num1++ + num2;
            Console.WriteLine($"{num1} + {num2} = {result1}");

            num1 = 0;
            num2 = 10;

            int result2 = ++num1 + num2++;
            Console.WriteLine($"{num1} + {num2} = {result2}");

            num1 = 0;
            num2 = 10;

            int result3 = num1-- + num1-- - --num2;
            Console.WriteLine($"{num1} + {num2} = {result3}");

            num1 = 0;
            num2 = 10;

            int result4 = num2++ * num1++ - --num2 + num1;
            Console.WriteLine($"{num1} + {num2} = {result4}");


        }
    }
}
