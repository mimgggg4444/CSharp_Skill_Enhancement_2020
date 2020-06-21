using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Car2
    {
        private int mPrice = 500000;

        public int price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if(value >= 50000)
                {
                    mPrice = value;
                }
            }
        }
    
        // public Car(Egas)
    }
}
