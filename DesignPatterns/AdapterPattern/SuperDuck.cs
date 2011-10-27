using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.AdapterPattern
{
    public class SuperDuck
    {
        protected string name;
        public SuperDuck(string _name)
        {
            name = _name;
        }
    }
}