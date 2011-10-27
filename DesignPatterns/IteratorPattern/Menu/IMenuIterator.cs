using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.IteratorPattern 
{
    interface IMenuIterator
    {
        IIterator createIterator();
    }
}
