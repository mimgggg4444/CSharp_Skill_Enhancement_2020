using System;

namespace 참조형
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CLASS_COUNT = 3;
            int[] STUDENT_COUNT_PER_CLASS = { 2, 1, 4 };

            String[][] classrooms = new string[CLASS_COUNT][];
            for (int i = 0; i < CLASS_COUNT; i++)
            {
                classrooms[i] = new string[STUDENT_COUNT_PER_CLASS[i]];

            }

            string[] classroom1 = classrooms[0];
            classroom1[0] = "Severus";

            Console.WriteLine();

            

        }

        public struct Vector2
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Vector2(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static Vector2 square
        }
    }
}
