using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RemoteService;

namespace DesignPatterns.ProxyPattern.RemoteProxy
{
    public static  class DrinkMachine
    {
        public static bool state { get; set; }
        public static int count { get; set; }
        public static string location { get; set; }
          static DrinkMachine()
        {
           
        }

        public static string SaleDrink()
        {
            if (count > 0)
            {
                count--;
                return "謝謝您，飲料售出-剩"+count +"";
            }
            else
            {
                state = false;
                return "不好意思，飲料售完";
            }
        }
        public static string RefillDrink(int _count)
        {
            count += _count;
            state = true;
            return string.Format("補貨完畢,目前有{0}罐<br/>", count);
        }

    }
}