using System;

namespace switchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //simple menu board
            Console.WriteLine("Please select a menu");
            Console.WriteLine("1. Cheese burger");
            Console.WriteLine("2. Double cheese burger");
            Console.WriteLine("3. Veggie burger");
            Console.WriteLine("4. Cheese & mushroom burger");

            int menu = int.Parse(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    Console.WriteLine("You selected a cheese burger");
                    Console.WriteLine("Price: $3");
                    break;
                case 2:
                    Console.WriteLine("You selected a Double cheese burger");
                    Console.WriteLine("Price: $3.5");
                    break;
                case 3:
                    Console.WriteLine("You selected a veggie burger");
                    Console.WriteLine("Price: $5");
                    break;
                case 4:
                    Console.WriteLine("You selected a Cheese & mushroom burger set");
                    Console.WriteLine("Price: $9.99");
                    break;
                default:
                    Console.WriteLine("Please enter a correct number(1~4)");
                    break;


        }
                    */
            //array
            int[] ages = new int[3];
            float[] heights = new float[3];

            Console.Write("Enter the first user's age: ");
            ages[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter the first user's height: ");
            heights[0] = float.Parse(Console.ReadLine());

            Console.Write("Enter the second user's age: ");
            ages[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter the second user's height: ");
            heights[1] = float.Parse(Console.ReadLine());

            Console.Write("Enter the third user's age: ");
            ages[2] = int.Parse(Console.ReadLine());
            Console.Write("Enter the third user's height: ");
            heights[2] = float.Parse(Console.ReadLine());

            Console.WriteLine("Print result----------");
            Console.WriteLine($"The first User: Age({ages[0]}), Height({heights[0]}cm)");
            Console.WriteLine($"The second User: Age({ages[1]}), Height({heights[1]}cm)");
            Console.WriteLine($"The third User: Age({ages[2]}), Height({heights[2]}cm)");

            int totalAges = ages[0] + ages[1] + ages[2];
            Console.WriteLine($"Total ages: {totalAges}");
            float totalHeights = heights[0] + heights[1] + heights[2];
            Console.WriteLine($"Total height: {totalHeights}");


            int[] ex = { 30, 14, 27 };
            ex[1] = int.Parse(Console.ReadLine());

            //char string
            char[] myName = new char[1024];
            myName[0] = 'L';
            myName[1] = 'L';
            myName[2] = 'L';
            myName[3] = 'L';
        }
    }
}
