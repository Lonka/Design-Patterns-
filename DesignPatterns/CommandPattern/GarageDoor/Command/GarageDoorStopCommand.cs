using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CommandPattern
{
    public class GarageDoorStopCommand : ICommand
    {
        GarageDoor garageDoor;
        EGarageDoorStatus egarageDoorStatus;
        public GarageDoorStopCommand(GarageDoor _garageDoor)
        {
            garageDoor = _garageDoor;
        }
        #region ICommand 成員

        public string Execute()
        {
            egarageDoorStatus = garageDoor.getStatus();
            return garageDoor.Stop();
        }

        public string Undo()
        {
            switch (egarageDoorStatus)
            {
                case EGarageDoorStatus.up:
                    return garageDoor.Up();
                case EGarageDoorStatus.stop:
                    return garageDoor.Stop();
                case EGarageDoorStatus.down:
                    return garageDoor.Down();
                default:
                    return garageDoor.Down();
            }
        }

        #endregion
    }
}