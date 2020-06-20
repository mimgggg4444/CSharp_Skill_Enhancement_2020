using System;

namespace Random1
{
    class Program
    {
        enum EShape
        {
            Rock,
            Paper,
            Scissor
        };

        static void Main(string[] args)
        {
            while(true)
            {
                Random random = new Random();
                EShape computer = (EShape)random.Next(3);

                Console.Write("Rock(0)~ Paper(1)~ Scissor(2)~: ");
                EShape user = (EShape)int.Parse(Console.ReadLine());

                if(computer == user)
                {
                    Console.WriteLine($"[Draw]\nYou ({user}), computer ({computer})");
                }
                else if((computer == EShape.Rock && user == EShape.Scissor) || (computer == EShape.Paper && user == EShape.Rock) || (computer == EShape.Scissor && user == EShape.Paper))
                {
                    Console.WriteLine($"[Lose]\nYou ({user}), computer({computer})");
                }
                else if((computer == EShape.Rock && user == EShape.Paper) || (computer == EShape.Paper && user == EShape.Scissor) || (computer == EShape.Scissor && user == EShape.Rock))
                {
                    Console.WriteLine($"[Win]\n ({user}), computer({computer})");
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }
}
