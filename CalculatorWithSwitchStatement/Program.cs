using System;

namespace CalculatorWithSwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("num2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("You choose operation(+, -, *, /): ");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine($"You entered a wrong operator: {operation}");
                    break;
            }
        }
    }
}
