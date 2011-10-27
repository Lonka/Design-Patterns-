using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class GreekPizzaTW : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory = null;
        public GreekPizzaTW()
        {
            pizzaIngredientFactory = new PizzaIngredientFactoryTW();
            name = "GreekPizza TW";
            dough = pizzaIngredientFactory.CreateDough().GetDough();
            sauce = pizzaIngredientFactory.CreateSauce().GetSauce(); ;
        }
        public override string Prepare()
        {
            return "GreekPizzaTW Prepare ";
        }
        public override string Bake()
        {
            return "GreekPizzaTW Bake";
        }
        public override string Cut()
        {
            return "GreekPizzaTW Cut";
        }
        public override string Box()
        {
            return "GreekPizzaTW Box";
        }
    }
}