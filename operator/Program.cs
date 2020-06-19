using System;

namespace operator1
{
    class Program
    {
    static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 30;
            int result = num1 + num2;
            //Console.WriteLine(result);

            int result1 = num1 - num2;
            uint result2 = (uint)num1 - (uint)num2;
            //Console.WriteLine($"{result1}, {result2}");

            int result3 = num1 * num2;
            //  double result4 = num1 / num2; 
            double result4 = num1 / (double)num2;
            Console.WriteLine("{0}", result4);

            int result5 = num1 % num2;
            
        }
    }
}
