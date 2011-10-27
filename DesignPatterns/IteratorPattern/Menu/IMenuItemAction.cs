using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.IteratorPattern
{
    interface IMenuItemAction
    {
        void AddItem(string name, string description, bool vegetarian, double price);
    }
}
