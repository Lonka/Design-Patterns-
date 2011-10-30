using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StatusPattern
{
    public class SuperState
    {
        protected GumballMachine gumballMachine;
        protected SuperState(GumballMachine _gumballMachine)
        {
            gumballMachine = _gumballMachine;
        }
    }
}