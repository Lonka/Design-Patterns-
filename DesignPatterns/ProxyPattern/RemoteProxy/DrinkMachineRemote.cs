using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemoteService;
namespace DesignPatterns.ProxyPattern.RemoteProxy
{
    class DrinkMachineRemote : MarshalByRefObject, IDrinkMachineRemote
    {
       
        public DrinkMachineRemote()
        {
        }

        #region IDrinkMachineRemote 成員

        public string GetLocation()
        {
            return DrinkMachine.location;
        }
        public int GetCount()
        {
            return DrinkMachine.count;
        }
        public bool GetState()
        {
            return DrinkMachine.state;
        }

        #endregion

        /// <summary>
        /// 讓此物件永不過期
        /// </summary>
        /// <returns></returns>
        public override Object InitializeLifetimeService()
        {
            return null;
        }
    }
}
