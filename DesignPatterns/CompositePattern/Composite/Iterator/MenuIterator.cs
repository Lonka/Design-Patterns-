using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CompositePattern
{
    public class MenuIterator : IIterator
    {
        List<MenuComponent> lsMenuIterator;
        int position = 0;
        public MenuIterator(List<MenuComponent> _lsMenuIterator)
        {
            lsMenuIterator = _lsMenuIterator;
        }

        #region IIterator 成員

        public bool hasNext()
        {
            if (lsMenuIterator.Count <= position || lsMenuIterator.Count == 0 )
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuComponent result = lsMenuIterator[position];
            position++;
            return result;
        }

        #endregion
    }
}