using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class PizzaStoreArea
    {
        public PizzaStore CreateStore(EPizzaArea ePizzaArea)
        {
            PizzaStore pizzaStore = null;
            switch (ePizzaArea)
            {
                case EPizzaArea.TW:
                    pizzaStore = new PizzaStoreTW();
                    break;
                case EPizzaArea.NY :
                    pizzaStore = new PizzaStoreNY();

                    break;
            }
            return pizzaStore;
        }
    }
}