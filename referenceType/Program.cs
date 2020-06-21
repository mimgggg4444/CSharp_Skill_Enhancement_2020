using System;

namespace referenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();
            SwapFace(human1, human2);
        
        }
    
        public static void SwapFace(Human human1, Human human2)
        {
            Face temp = human1.GetFace();
            human1.SetFace(human2.GetFace());
            human2.SetFace(temp);
        }
    }
}
