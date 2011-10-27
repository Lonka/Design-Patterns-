using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";
        protected EBeverageSize eBeverageSize;
        public  virtual    string getDescription()
        {
            return description;
        }
        public abstract  int cost();


        public virtual  EBeverageSize getSize()
        {
            return eBeverageSize ;
        }
       

 
    }
}