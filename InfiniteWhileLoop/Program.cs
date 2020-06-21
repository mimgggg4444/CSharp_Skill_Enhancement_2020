using System;

namespace InfiniteWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Input Number: ");
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    break;
                }

                Console.WriteLine("Number in hex: 0x{0:x}", input);
            }
        }
    }
}
