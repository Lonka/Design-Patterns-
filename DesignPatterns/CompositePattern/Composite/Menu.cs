using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CompositePattern
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> lsMenuComponent = new List<MenuComponent>();
        string name;
        string description;
        public Menu(string _name, string _description)
        {
            name = _name;
            description = _description;
        }

        public  override void Add(MenuComponent menuComponent)
        {
            lsMenuComponent.Add(menuComponent);
        }
        public override void Remove(MenuComponent menuComponent)
        {
            lsMenuComponent.Remove(menuComponent);
        }
        public  override MenuComponent getChild(int i)
        {
            return lsMenuComponent[i];
        }

        protected override string getName()
        {
            return name;
        }

        protected override string getDescription()
        {
            return description;
        }

        public override string Print()
        {
            string result = string.Empty;
            result += getName() + ","+getDescription () + "<BR/>";
            result += "------------------------------------------<BR/>";
            IIterator iterator = this.Iterator();
            while (iterator.hasNext())
            {
                MenuComponent mc = (MenuComponent)iterator.next();
                result += mc.Print();
            }
            result += "------------------------------------------<BR/>";

            return result;

        }

        private IIterator Iterator()
        {
            return new MenuIterator(lsMenuComponent);
        }



        public override IIterator CreateIterator()
        {
            return new CompositeIterator(this.Iterator());
        }
    }
}