using System;
using System.Text;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder builder = new StringBuilder(5);
            builder.Append("Hello kim!");
            builder.AppendLine(" What");
            builder.Append("GOOD!");

            builder.Insert(6, "bye bye! ");
            // builder.Replace('K', 'M', 14, 18);
            // builder.EnsureCapacity(1024);
            // builder.Clear();

            string greetings = builder.ToString();
            Console.WriteLine(greetings);
            Console.WriteLine($"Capacity: {builder.Capacity}, Length: {builder.Length}");
        }
    }
}
