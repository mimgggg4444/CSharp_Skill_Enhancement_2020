using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("minki");

            warrior.Introduce();
            warrior.GetStatus();

            warrior.SwordStrike();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.GetStatus();

            warrior.Rest();

            warrior.GetStatus();

            warrior.Health -= 200;

            warrior.GetStatus();
        }
    }
}
