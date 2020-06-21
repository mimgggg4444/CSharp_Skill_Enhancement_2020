using System;

namespace nullable123
{
    class Program
    {
        static void Main(string[] args)
        {
            int? age;
            age = 17;

            float? height = 180.0f;
            height = null;

            if(age != null)
            {
                Console.WriteLine(age.Value);
            }

            // int? age = null;
            if(age == 3)
            {
            }

            int? grade = 3;
            if(grade == 3)
            {
            }
        }
    }
}
