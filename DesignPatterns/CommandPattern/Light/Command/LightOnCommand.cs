using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CommandPattern
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light _light)
        {
            light = _light;
        }

        #region ICommand 成員

        public string Execute()
        {
            return light.On();
        }

        public string Undo()
        {
            return light.Off ();
        }

        #endregion
    }
}