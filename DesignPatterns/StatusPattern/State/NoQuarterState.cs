using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StatusPattern
{
    /// <summary>沒有代幣
    /// 
    /// </summary>
    public class NoQuarterState : SuperState, IStatus
    {
        public NoQuarterState(GumballMachine _gumballMachine)
            : base(_gumballMachine)
        {
        }
        #region IStatus 成員

        public string InsertQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
            return "You inserted a quarter<br/>";
        }

        public string EjectQuarter()
        {
            return "You haven't inserted a quarter<br/>";
        }

        public string TurnCrank()
        {
            return "You turned, but there's no quarter<br/>";
        }

        public string Dispense()
        {
            return "You need to pay first<br/>";
        }

        public string Refill()
        {
            gumballMachine.SetGumballCount();
            return "Refill gumball machine gumball count to 10<br/>";
        }

        #endregion

    }
}