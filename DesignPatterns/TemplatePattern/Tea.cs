using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.TemplatePattern
{
    public class Tea : CaffeineBeverage
    {
        public override string Brew()
        {
            return "Tea Brew";
        }
        public override string AddCondiments()
        {
            return "Tea AddCondiments";
        }
        
        public override bool Hook()
        {
            if (_isHook == "1")
                return true;
            else
                return false;
        }
    }

}