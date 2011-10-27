using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
   public  interface IPizzaIngredientFactory
    {
         IDough CreateDough();
         ISauce CreateSauce();
    }
}
