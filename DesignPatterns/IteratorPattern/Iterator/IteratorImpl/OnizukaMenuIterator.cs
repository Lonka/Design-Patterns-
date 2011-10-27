using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.IteratorPattern
{
    public class OnizukaMenuIterator : IIterator
    {
        int position = 0;
        List<MenuItem> menuItems;
        public OnizukaMenuIterator(List<MenuItem> _menuItems)
        {
            menuItems = _menuItems;
        }

        #region IIterator 成員

        public bool hasNext()
        {
            if (position >= menuItems.Count || menuItems[position ] == null )
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