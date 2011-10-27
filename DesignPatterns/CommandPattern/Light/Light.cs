using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CommandPattern
{
    public class Light
    {
        public string On()
        {
            return "Light On";
        }
        public string Off()
        {
            return "Light Off";
        }

    }
}