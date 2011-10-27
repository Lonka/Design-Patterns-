using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DesignPatternIntroduction.Interface.QuackImplement
{
    public class MuteQuack:IQuackBehavior
    {
        #region IQuackBehavior 成員

        public string DuckSound
        {
            get { return "Mute Mute Mute Quack"; }
        }

        public void DoDuckSound()
        {
        }

        #endregion
    }
}