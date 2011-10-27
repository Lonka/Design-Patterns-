using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CommandPattern
{
    public class LightOffCommand : ICommand 
    {
        Light light;
        public LightOffCommand(Light _light)
        {
            light = _light;
        }
        #region ICommand 成員

        public string Execute()
        {
            return light.Off ();
        }

        public string Undo()
        {
            return light.On ();
        }

        #endregion
    }
}