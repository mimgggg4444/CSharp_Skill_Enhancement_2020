using System;

namespace epsilon
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 2.3215488f;
            float num2 = 2.3215488f;

            // C# is 1.401298 * 10^-45
            
            if (Math.Abs(num1 - num2) <= Single.Epsilon)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            
        
        }
    }
}
