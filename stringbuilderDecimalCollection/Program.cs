using System;
using System.Collections.Generic;
using System.Text;
namespace stringbuilderDecimalCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            StringBuilder builder = new StringBuilder(4);
            builder.AppendLine("Hello world");
            builder.Append("Give me ");
            builder.Append(2);
            builder.Append(" dollars");
            // builder.Clear();

            builder.Insert(6, "good ");

            builder.Replace('o', 'a');

            string greetings = builder.ToString();
            Console.WriteLine(greetings);

            builder.EnsureCapacity(1024);
            Console.WriteLine($"capacity: {builder.Capacity}, Length: {builder.Length}");

            string greetingsText1 = builder.ToString();


            decimal num1 = 10.123456789123456789123456789123456798m;
            Console.WriteLine(num1);

            */


            List<int> scores = new List<int>(3);
            List<string> names = new List<string>();

            scores.Add(10);
            names.Add("kim");

            bool bResult1 = scores.Contains(40);
            Console.WriteLine(bResult1);

            int index1 = scores.IndexOf(10);
            Console.WriteLine(index1); // 1= true

            int[] dummy = { 20, 10 };
            scores.AddRange(dummy);

            scores.Insert(2, 10);

            bool bSuccess1 = scores.Remove(10);

            scores[0] = 10000;

            index1 = scores.LastIndexOf(10);
            Console.WriteLine(index1);

            Console.WriteLine($"{scores.Capacity}, {scores.Count}");


            List<string> namesTest = new List<string>(5);
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Name: {names[i]}");
            }

            Dictionary<string, string> studentsD = new Dictionary<string, string>();
            studentsD.Add("A10000", "Teemo");

            bool bSuccessD = studentsD.TryAdd("A10000", "Teemo");
            bool bContain1 = studentsD.ContainsKey("A10000");

            /*
            string value;
            bool bFound1 = studentsD.TryGetValue("A10000", out Value);
            */


            Console.WriteLine(bContain1);


            Dictionary<int, int> scoresD = new Dictionary<int, int>();


            HashSet<int> studentIDs = new HashSet<int>();
            bool HbSuccess1 = studentIDs.Add(20200621);

            bool HbSuccess2 = studentIDs.Contains(0);
            bool HbSuccess3 = studentIDs.Remove(0);

            Console.WriteLine();

            List<string> nameF = new List<string>(4096);
            nameF.Add("kim");
            nameF.Add("Lee");
            nameF.Add("jang");
            
            foreach(string name in nameF)
            {
                Console.WriteLine(name);
            }

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("100", "kim");
            students.Add("101", "Lee");

            foreach(KeyValuePair<string, string> score in students)
            {
                Console.WriteLine($"Key: {score.Key}, Value: {score.Value}");
            }

            HashSet<int> studentIDsF = new HashSet<int>();
            studentIDsF.Add(20200621);
            studentIDsF.Add(20200622);
            studentIDsF.Add(20200623);

            foreach (int studentID in studentIDsF)
            {
                Console.WriteLine(studentID);
            }

            foreach(var score in students)
            {
                Console.WriteLine($"Key: {score.Key}, Value: {score.Value}");
            }
        }
    }
}
