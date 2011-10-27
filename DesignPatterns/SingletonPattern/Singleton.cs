using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        private volatile static Singleton singleton;
        private static readonly object isLock = new object();
        private Singleton()
        {
        }
        public static Singleton getInstance()
        {
            //加這句是為了只有當第一次建立時才做鎖定的動作
            if (singleton == null)
                lock (isLock)
                {
                    //為了避免當兩個都在等著進入lock時
                    //沒有下面這句時
                    //這樣第一個建了instance後
                    //第二個會馬上進來再建一個instance
                    if (singleton == null)
                        singleton = new Singleton();
                }
            return singleton;
        }

        private string DBConn;
        public string DBConnectionString
        {
            get { return DBConn; }
            set { DBConn = value; }
        }
    }
}