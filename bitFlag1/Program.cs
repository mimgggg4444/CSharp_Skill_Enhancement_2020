using System;

namespace bitFlag1
{
    class Program
    {
        static void Main(string[] args)
        {x
            const byte CC_ASLEEP = 0;
            const byte CC_AIRBORNE = 1;
            const byte CC_BLIND = 2;
            const byte CC_STUN = 3;
            // const byte CC_NONE = 0;


            byte myChampStatus = CC_ASLEEP;

            byte m1 = (1 << CC_BLIND);
            myChampStatus |= m1;

            byte m2 = (1 << CC_STUN) | (1 << CC_AIRBORNE);
            myChampStatus |= m2;

            byte m3 = (1 << CC_STUN);
            myChampStatus &= (byte)~m3;

            Console.WriteLine(Convert.ToString(myChampStatus, 2).PadLeft(8, '0'));

        }
    }
}
