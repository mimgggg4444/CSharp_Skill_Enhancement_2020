using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace property
{
    class Car
    {
        public enum EGasType
        {
            Gasoline,
            Diesel,
        };

        private const int MIN_PRICE = 500000;

        private int mPrice = MIN_PRICE;

        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                if(value >= MIN_PRICE)
                {
                    mPrice = value;
                }
            }
        }

        public float Gas { get; private set; }
        public EGasType GasType { get; private set; }
        public string Owner { get; set; }

        private float mKillometersTravelled;

        public Car(EGasType gasType, int price)
        {
            GasType = gasType;
            Price = price;
        }

        public void FillUp(float gas)
        {
            Gas += gas;
        }

        public void Move()
        {
            reduceGas(0.5f);
            mKillometersTravelled += 0.3f;

            Console.WriteLine("Move");
            Console.WriteLine($"(Gas: {Gas}L left)");
            Console.WriteLine($"(Total move: {mKillometersTravelled}km)");
        }

        public void honk()
        {
            Console.WriteLine("Honk~");
        }

        private void reduceGas(float consumedGas)
        {
            Gas -= consumedGas;
        }
    }
}
