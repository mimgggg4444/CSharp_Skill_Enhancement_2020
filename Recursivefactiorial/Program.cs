using System;

namespace Recursivefactiorial
{
    class Program
    {
        static void Main(string[] args)
        {
            const ulong FACTORIAL = 10;

            Console.WriteLine(NonRecursiverFactorial(FACTORIAL));
            Console.WriteLine();
            Console.WriteLine(RecursiverFactorial(FACTORIAL));


        }

        static ulong NonRecursiverFactorial(ulong n)
        {
            if(n <= 1)
            {
                return 1;
            }

            uint factorial = 1;
            for(uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static ulong RecursiverFactorial(ulong n)
        {
            if(n == 0)
            {
                return 1;
            }

            return RecursiverFactorial(n - 1) * n;
        }
    }
}
