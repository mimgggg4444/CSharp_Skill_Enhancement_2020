using System;

namespace Add_two_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            // Console.Write(x + "+" + y + "=");
            // Console.Write(x + y);

            float num1;
            num1 = 128.512f;

            float num2 = 20.8f;
            const float PI = 3.14f;

            Console.Write(num1 + "+" + num2 + "=");
            Console.WriteLine(num1 + num2);

            Console.WriteLine();

            Console.Write(num1 + "-" + num2 + "=");
            Console.WriteLine(num1 - num2);

            Console.WriteLine();

            Console.Write(num1 + "*" + num2 + "=");
            Console.WriteLine(num1 * num2);

            Console.WriteLine();

            Console.Write(num1 + "/" + num2 + "=");
            Console.WriteLine(num1 / num2);

        }
    }
}
