using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.IteratorPattern
{
    public class MenuItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool vegetarian { get; set; }
        public double price { get; set; }
    }
}