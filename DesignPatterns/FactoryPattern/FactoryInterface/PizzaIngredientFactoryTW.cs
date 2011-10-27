using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class PizzaIngredientFactoryTW : IPizzaIngredientFactory 
    {
        #region IPizzaIngredientFactory 成員

        public IDough CreateDough()
        {
            return new DoughTW();
        }

        public ISauce CreateSauce()
        {
           return new SauceTW ();
        }

        #endregion
    }
}