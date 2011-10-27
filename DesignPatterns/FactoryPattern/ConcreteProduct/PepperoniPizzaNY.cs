using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class PepperoniPizzaNY : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory = null;
        public PepperoniPizzaNY()
        {
            pizzaIngredientFactory = new PizzaIngredientFactoryNY();
            name = "PepperoniPizza NY";
            dough = pizzaIngredientFactory.CreateDough().GetDough();
            sauce = pizzaIngredientFactory.CreateSauce().GetSauce(); ;
        }
        public override string Prepare()
        {
            return "PepperoniPizzaNY Prepare ";
        }
        public override string Bake()
        {
            return "PepperoniPizzaNY Bake";
        }
        public override string Cut()
        {
            return "PepperoniPizzaNY Cut";
        }
        public override string Box()
        {
            return "PepperoniPizzaNY Box";
        }
    }
}