using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.AdapterPattern
{
    public class MallardDuck : SuperDuck , IDuck
    {
        public MallardDuck(string name):base (name)
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