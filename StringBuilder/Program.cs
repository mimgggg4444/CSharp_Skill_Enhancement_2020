using System;
using System.Text;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder builder = new StringBuilder(4096);
            builder.Append("Hello kim!");
            builder.AppendLine(" What");
            builder.Append("GOOD!");

            string greetings = builder.ToString();
            Console.WriteLine(greetings);
        }
    }
}
