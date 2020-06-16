using System;
using System.Collections.Generic;
using System.Text;

namespace static1
{
    class Cat
    {
        private static int mCount = 0;

        public static void ADDCat()
        {
            ++mCount;
        }

        public static int GetCatCount()
        {
            return mCount;
        }
    }
}
