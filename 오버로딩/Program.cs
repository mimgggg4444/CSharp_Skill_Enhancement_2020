using System;

namespace 오버로딩
{
    class Program
    {
        static void Main(string[] args)
        {

        }
   
        static void Print(int score)
        {
            Console.WriteLine($"Your score is {score}. ");
        }

        static void Print(string name)
        {
            Console.WriteLine($"Your name is {name}. ");
        }

        static void Print(float gpa, string name)
        {
            Console.WriteLine($"Hello, {name}!\nYour GPA is {gpa}. ");
        }
    
    }
}
