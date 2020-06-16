using System;
using System.IO;

namespace FileInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes1 = new byte[3] { 12, 65, 3 };
            File.WriteAllBytes(@"C:\C#\start3",bytes1);

            byte[] bytes2 = File.ReadAllBytes(@"");
            for(int i = 0; i < bytes2.Length; ++i)
            {
                Console.WriteLine(bytes2[i]);
            }


        }
    }
}
