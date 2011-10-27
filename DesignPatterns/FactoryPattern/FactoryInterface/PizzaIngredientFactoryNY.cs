using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class PizzaIngredientFactoryNY : IPizzaIngredientFactory 
    {
        #region IPizzaIngredientFactory 成員

        public IDough CreateDough()
        {
            return new DoughNY();
        }

        public ISauce CreateSauce()
        {
            return new SauceNY();
        }

        #endregion
    }
}