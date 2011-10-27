using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class SauceTW :ISauce
    {
        #region ISauce 成員

        public string GetSauce()
        {
            return "Sauce TW";
        }

        #endregion
    }
}