using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CommandPattern
{
    public class GarageDoor
    {
        private EGarageDoorStatus eGarageDoorStatus = EGarageDoorStatus.none;
        public string Up()
        {
            eGarageDoorStatus = EGarageDoorStatus.up;
            return "Garage Door Up";
        }
        public string Down()
        {
            eGarageDoorStatus = EGarageDoorStatus.down;
            return "Garage Door Down";
        }
        public string Stop()
        {
            eGarageDoorStatus = EGarageDoorStatus.stop;
            return "Garage Door Stop";
        }
        public EGarageDoorStatus getStatus()
        {
            return eGarageDoorStatus;
        }
    }
}