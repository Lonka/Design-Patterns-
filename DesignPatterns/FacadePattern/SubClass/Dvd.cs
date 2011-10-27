using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FacadePattern
{
    public class Dvd : IPowerOF 
    {
        #region IPowerOF 成員

        public string On()
        {
            return "Dvd on";
        }

        public string Off()
        {
            return "Dvd off";
        }

        #endregion
    }
}