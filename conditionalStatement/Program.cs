using System;

namespace conditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            if(op == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if(op == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }

            else
            {
                Console.WriteLine($"You entered a wrong operator: {op}");
            }
            */

            Console.Write("Enter your math score: ");
            int score = int.Parse(Console.ReadLine());

            if(score >= 90)
            {
                Console.WriteLine("Buy a game console");
            }
            else if(score >= 80)
            {
                Console.WriteLine("Buy some books");
            }
            else if(score >= 70)
            {
                Console.WriteLine("Pizza");
            }
            else
            {
                Console.WriteLine("you want die?");
            }
        }
    }
}
