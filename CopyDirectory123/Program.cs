using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CopyDirectory123
{
    public class Program
    {
        public static readonly string INPUT_DIRECTORY = Path.Combine(Directory.GetCurrentDirectory(), "input");
        public static readonly string OUTPUT_DIRECTORY = Path.Combine(Directory.GetCurrentDirectory(), "OUTPUT");



        
        static void Main(string[] args)
        {
                        
        }

        private static void copyDirectory(string sourcePath, string destPath)
        {
            var files = Directory.GetFiles(sourcePath);

            foreach(var file in files)
            {
                var fileName = Path.GetFileName(file);
                File.Copy(file, Path.Combine(destPath));
            }

            var directories = Directory.GetDirectories(sourcePath);

            foreach(var directory in directories)
            {
                var dest = directory.Replace(sourcePath, destPath);
                Directory.CreateDirectory(dest);
                copyDirectory(directory, dest);
            }
        }

        private static void cleanDirectory(string path)
        {
            if(Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);

                foreach(string filePath in files)
                {
                    File.Delete(filePath);
                }
                string[] directories = Directory.GetDirectories(path);
                foreach(string directoryPath in directories)
                {
                    cleanDirectory(directoryPath);
                }

                Directory.Delete(path);
            }
        }
    }
}
