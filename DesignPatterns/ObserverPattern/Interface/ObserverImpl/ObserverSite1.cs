using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.ObserverPattern.Interface.ObserverImpl
{
    public class ObserverSite1 : IObserver 
    {

        #region IObserver 成員

        public string Update(string data)
        {
            return data+"-I am Site1";
        }

        #endregion
    }
}