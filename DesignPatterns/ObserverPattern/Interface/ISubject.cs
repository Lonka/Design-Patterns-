using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ObserverPattern.Interface
{
    interface ISubject
    {
        void RegisterObserver(IObserver os);
        void RemoveObserver(IObserver os);
        void NotifyObserver();
        void SetChange();
    }
}
