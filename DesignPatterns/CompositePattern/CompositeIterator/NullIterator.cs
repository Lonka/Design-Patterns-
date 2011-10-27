using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CompositePattern
{
    public class NullIterator : IIterator 
    {
        #region IIterator 成員

        public bool hasNext()
        {
            return false;
        }

        public object next()
        {
            return null;
        }

        #endregion
    }
}