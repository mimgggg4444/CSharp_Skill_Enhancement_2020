using System;

namespace enumAndAssertFunction
{
    class Program
    {
        
        static void Move(int direction, ref int x, ref int y)
        {
        const int NORTH = 1;
        const int SOUTH = 2;
        const int EAST = 3;
        const int WEST = 4;

            switch (direction)
            {
                case NORTH:
                    y += 1;
                    break;
                case SOUTH:
                    y -= 1;
                    break;
                case EAST:
                    x += 1;
                    break;
                case WEST:
                    x -= 1;
                    break;
                default:
                    Console.WriteLine($"Your enter wrong direction!: {direction}");
                    break;
            }

            static void Main(string[] args)
            {
                int direction;
                int x = 0;
                int y = 0;

                while (true)
                {
                    Console.WriteLine($"Your location: ({x}, {y})");
                    Console.WriteLine("Where do you want go?");

                    direction = int.Parse(Console.ReadLine());
                    Move(direction, ref x, ref y);
                }
            }
        }
    }
}
