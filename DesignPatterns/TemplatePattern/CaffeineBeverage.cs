using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        private string result = string.Empty;
        public string PrepareRecipe()
        {
            ComponentMsg(BoilWater());
            ComponentMsg(Brew());
            ComponentMsg(PourInCup());
            if (Hook())
                ComponentMsg(AddCondiments());
            return result;
        }

        private void ComponentMsg(string msg)
        {
            result += msg + "<BR/>";
        }

        public string BoilWater()
        {
            return "BoilWater";
        }
        public string PourInCup()
        {
            return "PourInCup";
        }
        public abstract string Brew();
        public abstract string AddCondiments();

        protected  string _isHook;
        public string isHook
        {
            get { return _isHook; }
            set { _isHook = value; }
        }
        public virtual Boolean Hook()
        {
            return true;
        }

    }
}