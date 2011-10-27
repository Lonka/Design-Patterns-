using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.IteratorPattern
{
    public class OnizukaMenu : IMenuItemAction, IMenuIterator
    {
        List<MenuItem> menuItems;
        public OnizukaMenu()
        {
            menuItems = new List<MenuItem>();
            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 299.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 299.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 349.77);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 359.29);
        }


        #region IMenuItemAction 成員

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            menuItems.Add(new MenuItem() { name = name, description = description, vegetarian = vegetarian, price = price });
        }

        #endregion

        public List<MenuItem> getMenuItems()
        {
            return menuItems;
        }

        public IIterator createIterator()
        {
            return new OnizukaMenuIterator(menuItems);
        }
    }
}