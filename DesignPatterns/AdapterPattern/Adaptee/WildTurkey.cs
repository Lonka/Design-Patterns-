using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.AdapterPattern
{
    public class WildTurkey : SuperDuck ,ITurkey  
    {
        public WildTurkey(string name)
            : base(name)
        {
        }


        #region ITurkey 成員

        public string Gobble()
        {
            return name + " Gobble ";
        }

        public string Fly()
        {
            return name + " Fly Short ";
        }

        #endregion
    }
}