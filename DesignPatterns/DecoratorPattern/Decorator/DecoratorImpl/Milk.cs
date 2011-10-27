using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public class Milk :  Decorator  
    {
        /// <summary>
        /// 記著上一層的裝飾結果
        /// </summary>
        Beverage beverage;
        public Milk(Beverage _beverage)
        {
            beverage = _beverage;
        }
        public override  string getDescription()
        {
            eBeverageSize = beverage.getSize();
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return beverage.getDescription() + " , Milk(V 5) ";
                case EBeverageSize.Grande:
                    return beverage.getDescription() + " , Milk(G 4) ";
                case EBeverageSize.Tall:
                    return beverage.getDescription() + " , Milk(T 2) ";
                default:
                    return beverage.getDescription() + " , Milk(T 2) ";
            }
        }
        public override EBeverageSize getSize()
        {
            return beverage.getSize();
        }
        public override int cost()
        {
            eBeverageSize = beverage.getSize();
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return 5 + beverage.cost();
                case EBeverageSize.Grande:
                    return 4 + beverage.cost();
                case EBeverageSize.Tall:
                    return 2 + beverage.cost();
                default:
                    return 2 + beverage.cost();
            }
        }

    }
}