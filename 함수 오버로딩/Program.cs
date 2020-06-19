using System;
using System.Runtime.InteropServices;

namespace 함수_오버로딩
{
    class Program
    {
        



        static void Print(int score)
        {
            Console.WriteLine($"Your score is {score}.");
        }
        static void Print(string name)
        {
            Console.WriteLine($"Your name is {name}.");
        }
        static void Print(float gpa, string name)
        {
            Console.WriteLine($"Hello, {name}!\nYour GPA is {gpa}.");
        }

        static void Main(string[]args)
        {
            Print(10);
            Print("Lulu");
            Print(89.9f, "Teemo");
        }

    }
}
