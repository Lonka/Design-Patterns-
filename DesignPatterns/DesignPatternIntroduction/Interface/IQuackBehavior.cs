using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.DesignPatternIntroduction.Interface
{
   public interface IQuackBehavior
    {
        string DuckSound
        {
            get;
        }
        void DoDuckSound();

    }
}
