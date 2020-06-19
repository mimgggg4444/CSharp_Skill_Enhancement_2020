using System;
using System.Collections.Generic;
using System.IO;

namespace UsingStatement
{
    public class Program
    {
        private static readonly string CURRENT_DIRECTORY = Directory.GetCurrentDirectory();
        private static readonly string OUTPUT_FOLDER_PATH = Path.Combine(CURRENT_DIRECTORY, "output");
        private static readonly string INPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "input", "inputtext.txt");
        private static readonly string OUTPUT_FILE_FULL_PATH = Path.Combine(CURRENT_DIRECTORY, "output", "outputtext.txt");

        public static void Main(string[]args)
        {
            setup();

        }

    }
}
