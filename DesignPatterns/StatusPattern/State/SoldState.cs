using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StatusPattern
{
    /// <summary>售出狀態
    /// 
    /// </summary>
    public class SoldState : SuperState, IStatus
    {
        public SoldState(GumballMachine _gumballMachine)
            : base(_gumballMachine)
        {
        }
        #region IStatus 成員

        public string InsertQuarter()
        {
            return "Please wait, we're alreade giveady giving you a gumball";
        }

        public string EjectQuarter()
        {
            return "Sorry, you already turned the crank<br/>";
        }

        public string TurnCrank()
        {
            return "Turning twice doesn't get you another gumball!<br/>";
        }

        public string Dispense()
        {
            if (gumballMachine.GetGumballCount() > 1)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState ());
                return "You get a gumball<br/>";
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
                return "Oops, out of gumballs!<br/>";
            }

        }
   public string Refill()
        {
            return "Sorry , please wait processing be complete <br/>";
        }
        #endregion

       
    }
}