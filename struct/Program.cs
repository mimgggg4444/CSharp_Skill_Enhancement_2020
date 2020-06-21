using System;
using System.Numerics;

namespace struct1
{
    class Program
{
        static void Main(string[]args)
        {
            Vector2 v1 = new Vector2(10, 20);
            Vector2 v2 = new Vector2(30, 40);
            Vector2 result = Vector2.Square(v1);
            Vector2.
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static Vector2 Square(Vector2 v)
        {
            v.X *= v.X;
            v.Y *= v.Y;
            return v;
        }

        

        public static void Square(ref Vector2 v)
        {
            v.X *= v.X;
            v.Y *= v.Y;
        }
}
}
