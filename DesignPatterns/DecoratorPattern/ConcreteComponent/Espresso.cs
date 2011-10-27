using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso(EBeverageSize size)
        {
            eBeverageSize = size;
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    description = "Espresso(55)";
                    break;
                case EBeverageSize.Grande:
                    description = "Espresso(45)";
                    break;
                case EBeverageSize.Tall:
                    description = "Espresso(35)";
                    break;
            }
        }
        
        public override int cost()
        {
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return 55;
                case EBeverageSize.Grande:
                    return 45;
                case EBeverageSize.Tall:
                    return 35;
                default:
                    return 35;
            }
        }


       

    }
}