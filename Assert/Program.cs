using System;

namespace Assert
{
    class Program
    {
        enum EMenu
        {
            Mune1 = 1,
            Mune2,
            Mune3,
            Mune4,
        }

        static double GetPrice(EMenu menu)
        {
            switch (menu)
            {
                case EMenu.Mune1:
                    return 10000;
                case EMenu.Mune2:
                    return 15000;
                case EMenu.Mune3:
                    return 20000;
                case EMenu.Mune4:
                    return 19999;
                default:
                    Console.WriteLine($"Worng menu: {menu}");
                    return -1;  //givw money back
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Select the menu(1~5): ");
                EMenu menu = (EMenu)int.Parse(Console.ReadLine());

                double price = GetPrice(menu);
                Console.WriteLine($"You will pay {price} won");
            }
        }
    }
}
