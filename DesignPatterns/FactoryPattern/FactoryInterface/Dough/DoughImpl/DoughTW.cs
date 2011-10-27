using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class DoughTW :IDough
    {
        #region IDough 成員

        public string GetDough()
        {
            return "Dough TW";
        }

        #endregion
    }
}