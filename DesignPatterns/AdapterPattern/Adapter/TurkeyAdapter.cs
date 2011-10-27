using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.AdapterPattern
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey turkey;
        public    TurkeyAdapter(ITurkey _turkey)
        {
            turkey = _turkey;
        }


        #region IDuck 成員

        public string Quack()
        {
           return  turkey.Gobble();
        }

        public string Fly()
        {
            string fly = string.Empty;
            for (int i = 0; i < 5; i++)
               fly+= turkey.Fly();
            return fly;
        }

        #endregion
    }
}