using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DesignPatternIntroduction.Interface.FlyImplement
{
    public class FlyWithWings:IFlyBehavior
    {



        #region IFlyBehavior 成員

        public string Fly()
        {
            return "I Fly With Wings";
        }

        #endregion
    }
}