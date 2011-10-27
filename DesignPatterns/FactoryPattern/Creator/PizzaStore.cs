using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public abstract class PizzaStore
    {
        //簡單工廠模式
        //SimplePizzaFactory simplePizzaFactory;
        //public PizzaStore(SimplePizzaFactory _simplePizzaFactory)
        //{
        //    simplePizzaFactory = _simplePizzaFactory;
        //}
        public Pizza OrderPizza(EPizzaFlavors ePizzaFlavors)
        {
            Pizza pizza = CreatePizza(ePizzaFlavors);
            return pizza;
        }
        public abstract Pizza CreatePizza(EPizzaFlavors ePizzaFlavors);
    }
}