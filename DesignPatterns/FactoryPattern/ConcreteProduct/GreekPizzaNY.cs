using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public class GreekPizzaNY : Pizza
    {
        IPizzaIngredientFactory pizzaIngredientFactory = null;
        public GreekPizzaNY()
        {
            //直接使用相對應的原料工廠
            pizzaIngredientFactory = new PizzaIngredientFactoryNY();
            name = "GreekPizza NY";
            //找出原料(CreateDough)並取得原料(GetDough)
            //且不需要知道是向誰取得
            dough = pizzaIngredientFactory.CreateDough().GetDough();
            sauce = pizzaIngredientFactory.CreateSauce().GetSauce(); ;
        }
        public override string Prepare()
        {
            return "GreekPizzaNY Prepare ";
        }
        public override string Bake()
        {
            return "GreekPizzaNY Bake";
        }
        public override string Cut()
        {
            return "GreekPizzaNY Cut";
        }
        public override string Box()
        {
            return "GreekPizzaNY Box";
        }
    }
}