using System;
using System.IO;
using System.Reflection.Metadata;

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
            catch(ArgumentNullException e)
            {
                Console.Error.WriteLine($"null argument: {e.Message}");
                return;
            }
            catch(Exception e)
            {
                Console.Error.WriteLine($"exception: {e}");
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
