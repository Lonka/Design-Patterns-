using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FacadePattern
{
    public class DvdFacade
    {
        Dvd dvd;
        Light light;
        Popper popper;
        Screen screen;
        string result = string.Empty;
        public DvdFacade(Dvd _dvd, Light _light, Popper _popper, Screen _screen)
        {
            dvd = _dvd;
            light = _light;
            popper = _popper;
            screen = _screen;
        }

        public string Open()
        {
            ComponentMsg(light.On());
            ComponentMsg(light.Dim(10));
            ComponentMsg(popper.On());
            ComponentMsg(popper.Pop());
            ComponentMsg(screen.On());
            ComponentMsg(screen.Down());
            ComponentMsg(dvd.On());
            return result;
        }
        public string Close()
        {
            ComponentMsg(dvd.Off());
            ComponentMsg(screen.Up());
            ComponentMsg(screen.Off());
            ComponentMsg(popper.Off());
            ComponentMsg(light.Off());
            return result;
        }
        public void ComponentMsg(string msg)
        {
            result += msg + "<Br/>";
        }
    }
}