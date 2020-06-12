using System;

namespace DefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar();
            Bar();
            Bar();

        }
    
        static void Bar(string s, string s2 = "", string s3 = "")
        {
            Console.WriteLine($"{s}, {s2}, {s3}");
        }
    }
}
