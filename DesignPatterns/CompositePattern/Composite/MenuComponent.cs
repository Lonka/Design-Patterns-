using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CompositePattern
{
    
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            
        }
        public virtual void Remove(MenuComponent menuComponent)
        {
        }
        public  virtual MenuComponent getChild(int i)
        {
            return null;
        }
        protected abstract string getName();
        protected abstract string getDescription();
        protected virtual double getPrice()
        {
            return 0;
        }
        public  virtual bool isVegetarian()
        {
            return false;
        }
        public abstract string Print();

        public abstract IIterator CreateIterator();
    }
}