using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.DesignPatternIntroduction.Interface.QuackImplement
{
    public class Quack:IQuackBehavior
    {
        #region IQuackBehavior 成員

        public string DuckSound
        {
            get { return "Quack Quack Quack"; }
        }

        public void DoDuckSound()
        {
        }

        #endregion

       
    }
}