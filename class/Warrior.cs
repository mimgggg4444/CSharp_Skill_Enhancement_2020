using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace classtest
{
    class Warrior
    {
        private const int MAX_HEALTH = 500;
        private const int MAX_MANA = 50;
        private const int MAX_STAMINA = 200;

        private int mHEALTH = MAX_HEALTH;
        private int mMANA = MAX_MANA;
        private int mSTAMINA = MAX_STAMINA;

        public Warrior(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public int Health
        {
            get
            {
                return mHEALTH;
            }
            set
            {
                mHEALTH = value;
                
                if(mHEALTH < 0)
                {
                    mHEALTH = 0;
                }

                if(mHEALTH > MAX_HEALTH)
                {
                    mHEALTH = MAX_HEALTH;
                }
            }
        }

        public int Mana
        {
            get
            {
                return mMANA;
            }
            set
            {
                mMANA = value;

                if(mMANA < 0)
                {
                    mMANA = 0;
                }
                if(mMANA > MAX_MANA)
                {
                    mMANA = MAX_MANA;
                }
            }
        }

        public int Stamina
        {
            get
            {
                return mSTAMINA;
            }
            set
            {
                mSTAMINA = value;

                if(mSTAMINA < 0)
                {
                    mSTAMINA = 0;
                }
                if(mSTAMINA > MAX_STAMINA)
                {
                    mSTAMINA = MAX_STAMINA;
                }
            }
        }

        public void Introduce()
        {
            Console.WriteLine($"I'm {Name}! Honour and glory!! THOS OS SPARTA!!");
        }

        public void UseWhirlwind()
        {
            if(Mana < 5 || Stamina < 70)
            {
                Console.WriteLine($"{Name} con't use Whirlwind!");
                return;
            }

            Mana -= 5;
            Stamina -= 70;

            Console.WriteLine($"{Name} used Whilrwind!");
        }

        public void SwordStrike()
        {
            if(Stamina < 20)
            {
                Console.WriteLine($"{Name} con't use SwordStrike! ");
                return;
            }

            Stamina -= 20;
            Console.WriteLine($"{Name} used SwordStrike! ");
        }

        public void Rest()
        {
            Mana += 2;
            Stamina += 5;
            Health += 5;

            Console.WriteLine($"{Name} is resting");
        }

        public void GetStatus()
        {
            Console.WriteLine($"{Name} - {Health} - {Mana} - {Stamina}");
        }
    }


}
