using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CompositePattern
{
    public class MenuItem : MenuComponent 
    {
        string name;
        string description;
        double price;
        bool vegetarian;
        public MenuItem(string _name, string _description, double _price, bool _vegetarian)
        {
            name = _name;
            description = _description;
            price = _price;
            vegetarian = _vegetarian;
        }

        protected override string getName()
        {
            return name;
        }

        protected override string getDescription()
        {
            return description;
        }
        protected override double getPrice()
        {
            return price;
        }
        public  override bool isVegetarian()
        {
            return vegetarian ;
        }

        public override string Print()
        {
            return "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + getName() + (isVegetarian() ? "(v)" : "") + "," + getPrice() + "<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;---" + getDescription() + "<br/>";
        }

        public override IIterator CreateIterator()
        {
            return new NullIterator();
        }
    }
}