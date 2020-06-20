using System;

namespace logicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1 = 10;
            int num2 = 20;
            if (++num2 == 20 || ++num1 == 10)
            {
                num1++;
            }

            Console.WriteLine($"{num1}, {num2}");
            */

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int max;
            if(num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }

            Console.WriteLine($"Max nuber is {max}");
        }
    }
}
