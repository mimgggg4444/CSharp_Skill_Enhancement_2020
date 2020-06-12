using System;
using System.Globalization;

namespace listOfStudentsUsing2d
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int CLASS_COUNT = 3;
            //const int STUDENT_COUNT = 5;

            //string[,] classrooms = new string[CLASS_COUNT, STUDENT_COUNT]
            //{
            //    {"sev","draco","bellatrix","","" },
            //    {"cedric","hannah","","","" },
            //    {"hermione","harry","leville","parvati","ron" }
            //};

            //for(int i = 0; i < CLASS_COUNT; i++)
            //{
            //    Console.WriteLine($"class{i + 1}Info***********************");

            //    for (int j = 0; j < STUDENT_COUNT; ++j)
            //    {
            //        Console.WriteLine($"Student{j + 1} name: {classrooms[i, j]}");
            //    }
            //    Console.WriteLine("********************************");
            //}

            const int CLASS_COUNT = 3;
            int[] STUDENT_COUNT_PER_CLASS = { 3, 2, 5 };
            string[][] classrooms = new string[CLASS_COUNT][];

            for (int i = 0; i < CLASS_COUNT; ++i)
            {
                classrooms[i] = new string[STUDENT_COUNT_PER_CLASS[i]];
            }

            int classIndex = 0;
            int studentIndex = 0;

            string[] studentNames = classrooms[classIndex];
            studentNames[studentIndex] = "Kimkimkim";

            Console.WriteLine($"class 1 - student 1: {classrooms[classIndex][studentIndex]}");
        }
    }
}
