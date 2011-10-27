using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.AdapterPattern
{
    public class BlackDuck : SuperDuck, IDuck
    {
        public BlackDuck(string name)
            : base(name)
        {
        }


        #region IDuck 成員

        public string Quack()
        {
            return name + " Quack ";
        }

        public string Fly()
        {
            return name + " Fly ";
        }

        #endregion
    }
}