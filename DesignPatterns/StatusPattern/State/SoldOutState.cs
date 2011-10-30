using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StatusPattern
{
    /// <summary>售光狀態
    /// 
    /// </summary>
    public class SoldOutState : SuperState, IStatus
    {
        public SoldOutState(GumballMachine _gumballMachine)
            : base(_gumballMachine)
        {
        }
        #region IStatus 成員

        public string InsertQuarter()
        {
            return "Sorry, haven't another gumball<br/>";
        }

        public string EjectQuarter()
        {
            return "Sorry, haven't another gumball<br/>";
        }

        public string TurnCrank()
        {
            return "Sorry, haven't another gumball<br/>";
        }

        public string Dispense()
        {
            return "Sorry, haven't another gumball<br/>";
        }
        public string Refill()
        {
            gumballMachine.SetGumballCount();
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            return "Refill gumball machine gumball count to 10<br/>";
        }
        #endregion


    }
}