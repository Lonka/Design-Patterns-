using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StatusPattern
{
    /// <summary>有代幣狀態
    /// 
    /// </summary>
    public class HasQuarterState : SuperState, IStatus
    {
        public HasQuarterState(GumballMachine _gumballMachine)
            : base(_gumballMachine)
        {
        }
        #region IStatus 成員

        public string InsertQuarter()
        {
            return "You can't insert another quarter<br/>";
        }

        public string EjectQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            return "Quarter returned<br/>";
        }

        public string TurnCrank()
        {
            int winner = new Random().Next(1, 10);
            if (winner == 1)
                if (gumballMachine.GetGumballCount() >= 2)
                    gumballMachine.SetState(gumballMachine.GetWinnerSoldState());
                else
                    gumballMachine.SetState(gumballMachine.GetSoldState());
            else
                gumballMachine.SetState(gumballMachine.GetSoldState());
            return "You turned...<br/>";
        }

        public string Dispense()
        {
            return "No gumball dispensed<br/>";
        }

        public string Refill()
        {
            return "Sorry , please wait processing be complete <br/>";
        }

        #endregion


    }
}