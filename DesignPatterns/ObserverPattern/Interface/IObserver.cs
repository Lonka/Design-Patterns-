using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ObserverPattern.Interface
{
    public interface IObserver
    {
        string Update(string data);
    }
}
