using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public class HouseBlend:Beverage 
    {
        public HouseBlend(EBeverageSize size)
        {
            eBeverageSize = size;
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    description = "HouseBlend(90)";
                    break;
                case EBeverageSize.Grande:
                    description = "HouseBlend(80)";
                    break;
                case EBeverageSize.Tall:
                    description = "HouseBlend(70)";
                    break;
            }
        }
        
        public override  int cost()
        {
            switch (eBeverageSize )
            {
                case EBeverageSize.Venti:
                    return 90;
                case EBeverageSize.Grande:
                    return 80;
                case EBeverageSize.Tall:
                    return 70;
                default:
                    return 70;
            }
        }
       
    }
}