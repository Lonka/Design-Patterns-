using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FacadePattern
{
    public class Light : IPowerOF
    {
        #region IPowerOF 成員

        public string On()
        {
            return "Light on";
        }

        public string Off()
        {
            return "Light off";
        }

        #endregion

        public string Dim(int num)
        {
            return "Dim light to " + num;
        }
    }
}