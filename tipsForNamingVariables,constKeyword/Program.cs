using System;

namespace tipsForNamingVariables_constKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 28;
            int b = 20;
            Console.WriteLine(a + b);

            int appleCount = 17;
            int orangeCount = 20;
            */

            const int APPLE_COUNT = 17;
            const int ORANGE_COUNT = 20;

            Console.WriteLine(APPLE_COUNT + ORANGE_COUNT);


        }
    }
}
