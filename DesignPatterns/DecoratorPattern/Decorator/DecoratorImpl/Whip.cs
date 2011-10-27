using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public class Whip : Decorator
    {
        /// <summary>
        /// 記著上一層的裝飾結果
        /// </summary>
        Beverage beverage;
        public Whip(Beverage _beverage)
        {
            beverage = _beverage;
        }
        public override EBeverageSize getSize()
        {
            return beverage.getSize();
        }
        public override int cost()
        {
            eBeverageSize = beverage.getSize ();
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return 20 + beverage.cost();
                case EBeverageSize.Grande:
                    return 10 + beverage.cost();
                case EBeverageSize.Tall:
                    return 5 + beverage.cost();
                default:
                    return 5 + beverage.cost();
            }
        }
        public override string getDescription()
        {
            eBeverageSize = beverage.getSize();
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return beverage.getDescription() + " , Whip(V 20) ";
                case EBeverageSize.Grande:
                    return beverage.getDescription() + " , Whip(G 10) ";
                case EBeverageSize.Tall:
                    return beverage.getDescription() + " , Whip(T 5) ";
                default:
                    return beverage.getDescription() + " , Whip(T 5) ";
            }

        }
    }
}