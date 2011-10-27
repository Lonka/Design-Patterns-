using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FacadePattern
{
    public class Popper : IPowerOF
    {

        #region IPowerOF 成員

        public string On()
        {
            return "Popper on";
        }

        public string Off()
        {
            return "Popper off";
        }

        #endregion

        public string Pop()
        {
            return "Popper do pop";
        }
    }
}