using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class PepperoniPizzaTW : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory = null;
        public PepperoniPizzaTW()
        {
            pizzaIngredientFactory = new PizzaIngredientFactoryTW();
            name = "PepperoniPizza TW";
            dough = pizzaIngredientFactory.CreateDough().GetDough();
            sauce = pizzaIngredientFactory.CreateSauce().GetSauce(); ;
        }
        public override string Prepare()
        {
            return "PepperoniPizzaTW Prepare ";
        }
        public override string Bake()
        {
            return "PepperoniPizzaTW Bake";
        }
        public override string Cut()
        {
            return "PepperoniPizzaTW Cut";
        }
        public override string Box()
        {
            return "PepperoniPizzaTW Box";
        }
    }
}