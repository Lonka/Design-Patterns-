using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DesignPatternIntroduction.Interface.QuackImplement
{
    public class Squeak:IQuackBehavior
    {

        #region IQuackBehavior 成員

        public string DuckSound
        {
            get { return "Squeak Squeak Squeak"; }
        }

        public void DoDuckSound()
        {
            
        }

        #endregion
    }
}