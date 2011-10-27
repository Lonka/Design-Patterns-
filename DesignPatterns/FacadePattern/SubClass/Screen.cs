using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FacadePattern
{
    public class Screen : IPowerOF
    {
        #region IPowerOF 成員

        public string On()
        {
            return "Screen on";
        }

        public string Off()
        {
            return "Screen off";
        }

        #endregion

        public string Up()
        {
            return "Screen up";
        }
        public string Down()
        {
            return "Screen down";
        }
    }
}