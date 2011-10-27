using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public class Soy : Decorator
    {
        /// <summary>
        /// 記著上一層的裝飾結果
        /// </summary>
        Beverage beverage;
        public Soy(Beverage _beverage)
        {
            beverage = _beverage;
        }
        public override string getDescription()
        {
            eBeverageSize = beverage.getSize();
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return beverage.getDescription() + " , Soy(V 8) ";
                case EBeverageSize.Grande:
                    return beverage.getDescription() + " , Soy(G 6) ";
                case EBeverageSize.Tall:
                    return beverage.getDescription() + " , Soy(T 5) ";
                default:
                    return beverage.getDescription() + " , Soy(T 5) ";
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
                    return 8 + beverage.cost();
                case EBeverageSize.Grande:
                    return 6 + beverage.cost();
                case EBeverageSize.Tall:
                    return 5 + beverage.cost();
                default:
                    return 5 + beverage.cost();
            }
        }
    }
}