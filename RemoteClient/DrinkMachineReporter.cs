using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RemoteService;

namespace RemoteClient
{
    public class DrinkMachineReporter
    {
        IDrinkMachineRemote drinkMachine;
        public DrinkMachineReporter(IDrinkMachineRemote drinkMachine)
        {
            this.drinkMachine = drinkMachine;
        }
        public string Report()
        {
            return "飲料機的位置：" + drinkMachine.GetLocation() +Environment.NewLine +"飲料機的狀態：" + drinkMachine.GetState() +  Environment.NewLine+"飲料機的庫存：" + drinkMachine.GetCount();
        }
    }
}