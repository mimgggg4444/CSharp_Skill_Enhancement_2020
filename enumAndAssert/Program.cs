using System;

namespace enumAndAssert
{
    class Program
    {
            enum EDirection
        {
            North = 'a',
            South,
            East,
            West
        };
        static void Main(string[] args)
        {
            EDirection direction;
            int x = 0;
            int y = 0;

            EDirection direction2 = EDirection.East;
            Console.WriteLine(direction2);

            while(true)
            {
                Console.WriteLine($"Your location: ({x}, {y})");
                Console.WriteLine("Where do you want go?(n - 0, s - 1, n - 2, w -3)");
                direction = (EDirection)int.Parse(Console.ReadLine());

                switch(direction)
                {
                    case EDirection.North:
                        y += 1;
                        break;

                    case EDirection.South:
                        y -= 1;
                        break;

                    case EDirection.East:
                        x += 1;
                        break;

                    case EDirection.West:
                        x -= 1;
                        break;
                    default:
                        Console.WriteLine($"You enter wrong direction!: {direction}");
                        break;
                }
            }
        }
    }
}
