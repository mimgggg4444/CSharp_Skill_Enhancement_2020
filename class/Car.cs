using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace class1
{
    class Car
    {
        private int mPrice = 500000;

        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if(value >= 500000)
                {
                    mPrice = value;
                }
            }
        }

    }

}
