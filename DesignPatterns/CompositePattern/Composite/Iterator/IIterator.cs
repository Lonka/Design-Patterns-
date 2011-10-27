using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CompositePattern
{
   public  interface IIterator
    {
        bool hasNext();
        object next();
    }
}
