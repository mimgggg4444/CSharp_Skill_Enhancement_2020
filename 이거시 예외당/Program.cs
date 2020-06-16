using System;
using System.IO;

namespace 이거시_예외당
{
    class Program
    {
        static void PrintLines(string path)
        {
            if(!File.Exists(path))
            {
                return;
            }

            string[] lines;
            try
            {
                lines = File.ReadAllLines(path);
            }
            catch(FileNotFoundException e)
            {
                Console.Error.WriteLine($"file not found: {e}");
                return;
            }

            foreach(var line in lines)
            {
                
            }
        }

        static void Main(string[]args)
        {
            string path = @"C:\start";
            PrintLines(path);

        }
            


    }
}
