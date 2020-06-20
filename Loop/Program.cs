using System;
using System.Threading;
using System.Transactions;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("User count: ");
            int length = int.Parse(Console.ReadLine());

            int[] ages = new int[length];
            float[] heights = new float[length];

            int totalAges = 0;
            float totalHeights = 0.0f;
            for(int i = 0; i < length; i++)
            {
                Console.Write($"Enter user{i}'s age: ");
                ages[i] = int.Parse(Console.ReadLine());
                totalAges += ages[i];

                Console.Write($"Enter user{i}'s height: ");
                heights[i] = float.Parse(Console.ReadLine());
                totalHeights += heights[i];
            }

            Console.WriteLine("print result--------");
            for(int i = 0; i < length; ++i)
            {
                Console.WriteLine($"User{i}: Age({ages[i]}), Height({heights[i]}cm)");
            }
            */

            /*
            Console.Write("User count: ");
            int length = int.Parse(Console.ReadLine());
            int[] ages = new int[length];
            float[] heights = new float[length];

            int totalAge = 0;
            float totalHeight = 0.0f;
            int count = 0;
            while(count < length)
            {
                Console.Write($"Enter user {count}'s age: ");
                ages[count] = int.Parse(Console.ReadLine());
                totalAge += ages[count];

                Console.Write($"Enter user {count}'s height: ");
                heights[count] = float.Parse(Console.ReadLine());
                totalHeight += heights[count];

                ++count;
            }
            Console.WriteLine($"Total ages: {totalAge}");
            Console.WriteLine($"Total height: {totalHeight}");
            */

            /*
            string passcode = "111a";
            string userInput = "";

            while(true)
            {
                Console.Write("Please enter the password: ");
                userInput = Console.ReadLine();

                if(passcode == userInput)
                {
                    Console.WriteLine("open the door");
                    break;
                }

                Console.WriteLine("wrong password!");
                
            }
            

            Console.Write("User count: ");
            int length = int.Parse(Console.ReadLine());
            int[] ages = new int[length];
            float[] heights = new float[length];

            int totalAge = 0;
            float totalHeight = 0.0f;
            int count = 0;
            do
            {
                Console.Write($"Enter user {count}'s age: ");
                ages[count] = int.Parse(Console.ReadLine());
                totalAge += ages[count];

                Console.Write($"Enter user {count}'s height: ");
                heights[count] = float.Parse(Console.ReadLine());
                totalHeight += heights[count];

                ++count;
            }while (count < length);

            Console.WriteLine($"Total ages: {totalAge}");
            Console.WriteLine($"Total heights: {totalHeight}");
            */

            Console.Write("Enter the number of scores: ");
            int length = int.Parse(Console.ReadLine());
            int[] scores = new int[length];

            int totalScores = 0;
            for (int i = 0; i < length; ++i)
            {
                Console.Write($"Enter your score ({i + 1}):");
                scores[i] = int.Parse(Console.ReadLine());
                totalScores += scores[i];
            }

            Console.WriteLine($"Average = {totalScores / (float)length}");


            string passcode = "1234";

            string userInput = "";
            while(true)
            {
                Console.Write("Please enter the password: ");
                userInput = Console.ReadLine();

                if(passcode == userInput)
                {
                    Console.WriteLine("Welcom home");
                    break;
                }
            }

            Console.WriteLine("wrong password");
            
        }
    }
}
