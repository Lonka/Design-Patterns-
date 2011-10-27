using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DesignPatternIntroduction.Interface.FlyImplement
{
    public class FlyNoWay:IFlyBehavior 
    {



        #region IFlyBehavior 成員

        string IFlyBehavior.Fly()
        {
            return "I Can't Fly";
        }

        #endregion
    }
}