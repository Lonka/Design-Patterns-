using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.TemplatePattern
{
    public class Coffee : CaffeineBeverage
    {
        public override string Brew()
        {

            return "Coffee Brew";
        }
        public override string AddCondiments()
        {

            return "Coffee AddCondiments";
        }
    }
}