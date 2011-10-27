using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class PizzaStoreNY : PizzaStore 
    {
        public override Pizza CreatePizza(EPizzaFlavors ePizzaFlavors)
        {
            Pizza pizza = null;
            if (ePizzaFlavors == EPizzaFlavors.GreekPizza)
            {
                pizza = new GreekPizzaNY();
            }
            else if (ePizzaFlavors == EPizzaFlavors.PepperoniPizza)
            {
                pizza = new PepperoniPizzaNY();
            }
            return pizza;
        }
    }
}