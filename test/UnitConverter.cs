using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class UnitConverter
    {
        public static double GetInchesFromCentimeters(double centimeters)
        {
            return centimeters * 0.393701;
        }

        public static double GetCentimetersFromInches(double centimeters)
        {
            return centimeters / 100;
        }

        public static double GetFeetFromInches(double inches)
        {
            return inches / 12;
        }
    }
}
