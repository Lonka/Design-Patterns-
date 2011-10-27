using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.IteratorPattern
{
    public class LonkaMenuIterator : IIterator
    {
        MenuItem[] menuItems;
        int position = 0;
        public LonkaMenuIterator(MenuItem[] _menuItems)
        {
            menuItems = _menuItems;
        }

        #region IIterator 成員

        public bool hasNext()
        {
            if (position >= menuItems.Length || menuItems[position] == null)
                return false;
            else
                return true;
        }

        public object next()
        {
            MenuItem menuItem = menuItems[position];
            position++;
            return menuItem;
        }

        #endregion
    }
}