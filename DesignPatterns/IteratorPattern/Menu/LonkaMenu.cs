using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.IteratorPattern
{
    public class LonkaMenu : IMenuItemAction, IMenuIterator
    {
        MenuItem[] menuItems;
        static readonly int maxItems = 4;
        private int numberOfItems = 0;
        public LonkaMenu()
        {
            menuItems = new MenuItem[maxItems];
            AddItem("Vegetarian BLT", "(Fakin')Bacon with lettuce tomato on whole wheat", true, 299.99);
            AddItem("BLT", "Bacon with lettuce tomato on whole wheat", false, 299.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false , 311.77);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 305.29);
        }

        #region IMenuItemAction 成員

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (numberOfItems >= maxItems)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                menuItems[numberOfItems] = new MenuItem() { name = name, description = description, vegetarian = vegetarian, price = price };
                numberOfItems++;
            }
        }

        #endregion

        public MenuItem[] getMenuItems()
        {
            return menuItems;
        }

        public IIterator createIterator()
        {
            return new LonkaMenuIterator(menuItems);
        }
    }
}