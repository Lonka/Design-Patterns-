using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class DoughNY : IDough
    {
        #region IDough 成員

        public string GetDough()
        {
            return "Dough NY";
        }

        #endregion
    }
}