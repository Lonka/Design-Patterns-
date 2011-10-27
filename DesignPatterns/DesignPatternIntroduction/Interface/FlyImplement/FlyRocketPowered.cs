using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DesignPatternIntroduction.Interface.FlyImplement
{
    public class FlyRocketPowered : IFlyBehavior
    {

        #region IFlyBehavior 成員

        string IFlyBehavior.Fly()
        {
            return "I Fly With RocketPowered";
        }

        #endregion
    }
}