using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a 
            /*
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };
            double average = Average(Sum(scores), scores.Length);
            PrintAverage(average, scores.Length);

            while(true)
            {
                for(int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"Score{i}: {scores[i]}");
                }

                Console.WriteLine($"Which score do you want to update?(0~{scores.Length - 1})");
                int index = int.Parse(Console.ReadLine());
                if(index < 0 || index >= scores.Length)
                {
                    Console.WriteLine("Wrong index.");
                }
                else
                {
                    Console.Write("Enter the score: ");
                    scores[index] = double.Parse(Console.ReadLine());
                    average = Average(Sum(scores), scores.Length);
                    PrintAverage(average, scores.Length);
                }
            }
            */
            #endregion
            /*
            double num = double.Parse(Console.ReadLine());
            Square(num);
            Console.WriteLine($"Result: {num}");
            */

            double number = 5;
            Console.WriteLine(Square(number));

        }

        static int AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static double Square(double number)
        {
            number *= number;
            return number;
            // return result;  //띠바..
        }


        static double Sum(double[]scores)
        {
            double sum = 0.0;
            for(int i = 0; i < scores.Length; ++i)
            {
                sum += scores[i];
            }

            return sum;
        }

        static double Average(double data, int count)
        {
            data /= count;
            data = (int)(data * 10 + 0.5) / 10.0;
            return data;
        }

        static void PrintAverage(double average, int count)
        {
            Console.WriteLine("-----------");
            Console.WriteLine($"{count}scores average: {average:f1}");
            Console.WriteLine("-----------");

            Console.WriteLine("-----------");
        }
    }


}
