using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(EPizzaFlavors ePizzaFlavors)
        {
            Pizza pizza = null;
            if (ePizzaFlavors == EPizzaFlavors.GreekPizza)
            {
                pizza = new GreekPizzaTW();
            }
            else if (ePizzaFlavors == EPizzaFlavors.PepperoniPizza)
            {
                pizza = new PepperoniPizzaTW();
            }
            return pizza;
        }
    }
}