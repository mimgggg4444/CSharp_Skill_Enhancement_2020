

using System;

namespace arrayOfArrays
{
    class Program
    {
        static void Main(string[] args)
        /*
        {
            const int CLASS_COUNT = 2;
            const int STUDENT_COUNT = 2;

            string[,] classrooms = new string[CLASS_COUNT, STUDENT_COUNT]
            {
                {"kim", "kim" },
                {"kim", "kim" }
            };

            for(int i = 0; i < CLASS_COUNT; ++i)
            {
                Console.WriteLine($"Class{i + 1} Info*******");
                for(int j = 0; j < STUDENT_COUNT; ++j)
                {
                    Console.WriteLine($"Student{j + 1} name: {classrooms[i, j]}");
                }
                Console.WriteLine("***********");
            }
        }
        */
        {
            /*
            const int CLASS_COUNT = 3;
            String[][] Classrooms = new string[CLASS_COUNT][];
            int[] STUDENT_COUNT_PER_CLASS = { 3, 2, 5 };

            for(int i = 0; i < CLASS_COUNT; ++i)
            {
                Classrooms[i] = new string[STUDENT_COUNT_PER_CLASS[i]];
            }
            int classIndex = 0;
            string[] studentNames = Classrooms[classIndex];

            Console.WriteLine(studentNames.Length);

            string[] lines =
            {
                "aa, bb, cc",
                "ohoh,11,22"
            };

            for(int i = 0; i < lines; ++i)
            {
                string line = lines
            }
            */

            string message = "C# is very very fun!!";
            int index = message.IndexOf('v');
            Console.WriteLine(index);

            string message2 = message.Substring(6);
            Console.WriteLine(message2);

            string HPMessage = "HP: 100";
            char ch = HPMessage[4];
            Console.WriteLine(ch);

            string text = "Hello, 1, : 20000";
            string[] tokens = text.Split(',');

            char[] delimiters = { ',', ':' };
            string[] tokensSecond = HPMessage.Split(delimiters);
            Console.WriteLine(tokensSecond);

            string textText = "Hello,1:10000";
            char[] delimitersTest = { ',', ':' };
            string[] tokensText = textText.Split(delimitersTest, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(tokensText);
        }
    }

}

