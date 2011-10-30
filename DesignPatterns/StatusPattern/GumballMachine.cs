using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.StatusPattern
{
    public class GumballMachine
    {
        IStatus noQuarterState;
        IStatus hasQuarterState;
        IStatus soldState;
        IStatus soldOutState;
        IStatus winnerSoldState;
        IStatus state;

        int gumballsCount = 0;

        static GumballMachine gumballMachine;

        private GumballMachine(int numberGumballs)
        {
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);
            winnerSoldState = new WinnerSoldState(this);
            state = soldOutState;
            gumballsCount = numberGumballs;
            if (gumballsCount > 0)
                state = noQuarterState;

        }


        public static  GumballMachine CreateGumballMachine(int numberGumballs)
        {
            if (gumballMachine == null)
            {
                gumballMachine = new GumballMachine(numberGumballs);
            }
            return gumballMachine;
        }
        public string InsertQuarter()
        {
            return state.InsertQuarter();
        }

        public string EjectQuarter()
        {
            return state.EjectQuarter();
        }

        public string TurnCrank()
        {
            string result = state.TurnCrank() + (state == soldState ? state.Dispense() + ReleaseBall() : (state == winnerSoldState ? state.Dispense() + ReleaseBall() + ReleaseBall() : string.Empty));
            return result;
        }

        public string Refill()
        {
            return state.Refill();
        }

        public void SetState(IStatus _state)
        {
            state = _state;
        }

        public string ReleaseBall()
        {
            if (gumballsCount != 0)
            {
                gumballsCount -= 1;
            }
            return "Gumballs has " + gumballsCount+"<br/>";
        }


        public IStatus GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IStatus GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IStatus GetSoldState()
        {
            return soldState;
        }

        public IStatus GetSoldOutState()
        {
            return soldOutState;
        }

        public IStatus GetWinnerSoldState()
        {
            return winnerSoldState;
        }

        public int GetGumballCount()
        {
            return gumballsCount;
        }

        public void SetGumballCount()
        {
            gumballsCount = 10;
        }
        public string GetState()
        {
            if (state == noQuarterState)
                return "No Quarter";
            else if (state == hasQuarterState)
                return "Has Quarter";
            else if (state == soldState)
                return "Sold";
            else if (state == soldOutState)
                return "Sold Out";
            else
                return "Nothing";
        }
    }
}