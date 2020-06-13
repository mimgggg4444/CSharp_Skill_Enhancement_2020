using System;

namespace divisionFunction
{
    class Program
    {

        static bool TryDivide(float numerator, float denominator, out float result)
        {
            if(denominator == 0.0f)
            {
                result = 0.0f;
                return false;
            }

            result = numerator / denominator;
            return true;
        }

        static void Main(string[] args)
        {
            float result1;
            bool bSuccess1 = TryDivide(10.0f, 0.0f, out result1);
            float result2;
            bool bSuccess2 = TryDivide(10.0f, 5.0f, out result2);
            
            Console.WriteLine(bSuccess1);
            Console.WriteLine(bSuccess2);

        }
    }
}
