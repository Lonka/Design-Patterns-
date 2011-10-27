using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DecoratorPattern
{
    public class Mocha :   Decorator   
    {
        /// <summary>
        /// 記著上一層的裝飾結果
        /// </summary>
        Beverage beverage;
        public Mocha(Beverage _beverage)
        {
            beverage = _beverage;
        }
        public  override   string getDescription()
        {
            eBeverageSize = beverage.getSize();
            switch (eBeverageSize)
            {
                case EBeverageSize.Venti:
                    return beverage.getDescription() + " , Mocha(V 20) ";
                case EBeverageSize.Grande:
                    return beverage.getDescription() + " , Mocha(G 10) ";
                case EBeverageSize.Tall:
                    return beverage.getDescription() + " , Mocha(T 5) ";
                default:
                    return beverage.getDescription() + " , Mocha(T 5) ";
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
                    return 20 + beverage.cost();
                case EBeverageSize.Grande:
                    return 10 + beverage.cost();
                case EBeverageSize.Tall:
                    return 5 + beverage.cost();
                default:
                    return 5 + beverage.cost();
            }
        }
    }
}