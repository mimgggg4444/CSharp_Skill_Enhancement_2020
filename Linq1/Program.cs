using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[]args)
        {
            var menuItems = new List<MenuItem>();


            bool result1 = menuItems.All(m => new.price >= 0); //모든 데이터가 특정 조건을 만족하는지 평가

            bool result2 = menuItems.Any(m => new.price < 10); //하나라도 특정 조건을 만족하는지 평가


            var menuItems = new List<MenuItem>();
            List<menuItem> items1 = menuItems.Where(m => m.price < 15).ToString();
            menuItems[]items2 = menuItems


        }



    }
}
