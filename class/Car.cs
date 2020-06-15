using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace class1
{
    public class Car
    {

        public enum EGasType
        {
            Gasoline,
            Diesel
        };

        public string Owner;

        private float mGas;
        private EGasType mGasType;
        private int mPrice = 500000;
        private float mKillometersTravelled;



        public Car(EGasType gasType, int price)
        {
            mGasType = gasType;
            SetPrice(price);
        }

        public void SetPrice(int price)
        {
            if(price >= 500000)
            {
                mPrice = price;
            }
        }

        public int GetPrice()
        {
            return mPrice;
        }

        public float GetGas()
        {
            return mGas;
        }

        public void FillUp(float gas)
        {
            mGas += gas;
        }
        
        public void Move()
        {
            reduceGas(0.5f);
            mKillometersTravelled += 0.3f;

            Console.WriteLine("Move!");
            Console.WriteLine($"(Gas: {mGas}L left)");
            Console.WriteLine($"(Total move: {mKillometersTravelled}km)");
        }

        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
        }

        private void reduceGas(float consumedGas)
        {
            mGas -= consumedGas;
        }

    }

}
