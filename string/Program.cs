using System;

namespace string1
{
    class Program
{
    static void Main(string[] args)
    {
            /*
            string greeting = "Hi, everybody!";
            Console.WriteLine(greeting);
            */

            char[] greeting = { 'h','e','l','l','l','o' };

            /*
            Console.WriteLine(greeting);

            Console.WriteLine("Added message: " + "C# is awesom!");
            */

            /*
            string message1 = "Hello";
            string message2 = "Hello";

            Console.WriteLine(message1 == message2);

            Console.WriteLine("\"");

            Console.Write("Welcom\nkim\nBye~\n");
            Console.WriteLine("Welcom\tkim");
            */

            // string message1 = string.Format("Name: {0} / ID: {1}", name1, ID1);

            string studentName1 = "Lee";
            float winRate1 = 30.2351f;

            string studentName2 = "Oh";
            float winRate2 = 70.11f;

            Console.WriteLine("{0,-10}{1,-15}\n", "Name", "Win Rate");
            Console.WriteLine("{0,-10}{1,-15}", studentName1, winRate1);
            Console.WriteLine("{0,-10}{1,-15}", studentName2, winRate2);

            Console.WriteLine("{0:f4}", 3.1456532);
            Console.WriteLine("{0:x1}", 10);

            Console.Write("Hello worl\x64!\n");

            Console.Write("Enter the first number: ");
            string numStr1 = Console.ReadLine();
            int num1 = int.Parse(numStr1);

            Console.Write("Enter the second number: ");
            string numStr2 = Console.ReadLine();
            int num2 = int.Parse(numStr2);
            
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

        }
    }
}
